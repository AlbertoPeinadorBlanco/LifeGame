namespace LifeGame
{
    public partial class Form1 : Form
    {
        IOrganismFactory organismFactory;
        OrganismFactoryInjector organismInjector;

        IOrganismPainting organismPainting;
        OrganismPaintingInjector organismPaintingInjector;

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


        
        //////////////////////////
        //MAKE THIS INTO A CLASS//
        //////////////////////////
        private void gridDrawing()
        {
            Pen pen = new Pen(Color.Black);
            Point pointA = new Point();
            Point pointB = new Point();
            Point pointC = new Point();
            btm = new Bitmap(pbGrid.Width, pbGrid.Height);
            g = Graphics.FromImage(btm);

            GridDesign gd = new GridDesign(pbGrid, pointA, pointB, pen, g, btm);
            GridCoordinates gridCoordinates = new GridCoordinates();

            coordinates = gridCoordinates.cellCordinates(pbGrid.Height / 50, pointC);

            gd.drawGrid();

        }

        private void createOrganism()
        {
            organismFactory = new OrganismFactory(coordinates, pbGrid.Height / 50);
            organismInjector = new OrganismFactoryInjector(organismFactory);

            organismInjector.organismCreation();
        }


        private void paintOrganisms()
        {
            organismPainting = new OrganismPainting(btm, pbGrid, g);
            organismPaintingInjector = new OrganismPaintingInjector(organismPainting);

            organismPaintingInjector.organismsPaint();
            

        }

    }
}
