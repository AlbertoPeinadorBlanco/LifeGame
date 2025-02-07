namespace LifeGame
{
    public partial class Form1 : Form
    {
        IOrganismFactory organismFactory;
        OrganismFactoryInjector organismInjector;

        IOrganismPainting organismPainting;
        OrganismPaintingInjector organismPaintingInjector;

        IGridDesign gridDesign;
        GridDesignInjector gridDesignInjector;

        IGridCoordinates gridCoordinates;
        GridCoordinatesInjector gridCoordinatesInjector;

        int squareSide = 50;

        Bitmap btm;
        List<Point> coordinates;
        Graphics g;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridDrawing();
            createOrganism();
            paintOrganisms();
        }

        OrganismReproduction or;


        private void checkReproduction()
        {

            or = new OrganismReproduction(pbGrid.Height / squareSide);

            or.checkReproduction();

            gridDrawing();
            paintOrganisms();

        }
        private void gridDrawing()
        {
            Pen pen = new Pen(Color.Black);
            Point pointA = new Point();
            Point pointB = new Point();
            Point pointC = new Point();
            btm = new Bitmap(pbGrid.Width, pbGrid.Height);
            g = Graphics.FromImage(btm);

            gridDesign = new GridDesign(pbGrid, pointA, pointB, pen, g, btm);
            gridDesignInjector = new GridDesignInjector(gridDesign);

            gridCoordinates = new GridCoordinates();
            gridCoordinatesInjector = new GridCoordinatesInjector(gridCoordinates);

            coordinates = gridCoordinatesInjector.getCoordinates(pbGrid.Height / squareSide, pointC);

            gridDesignInjector.gridDraw();

        }

        private void createOrganism()
        {
            organismFactory = new OrganismFactory(coordinates, pbGrid.Height / squareSide);
            organismInjector = new OrganismFactoryInjector(organismFactory);

            organismInjector.organismCreation();
        }


        private void paintOrganisms()
        {
            organismPainting = new OrganismPainting(btm, pbGrid, g);
            organismPaintingInjector = new OrganismPaintingInjector(organismPainting);

            organismPaintingInjector.organismsPaint();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            checkReproduction();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
