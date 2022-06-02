using System;

namespace Bridge_Pattern
{

    interface IWebPage
    {
        string GetContent();
    }

    class Home : IWebPage
    {
        protected ITheme theme;

        public Home(ITheme theme)
        {
            this.theme = theme;
        }

        public string GetContent()
        {
            return $"Home page in {theme.GetColor()}";
        }
    }

    class About : IWebPage
    {
        protected ITheme theme;

        public About(ITheme theme)
        {
            this.theme = theme;
        }

        public string GetContent()
        {
            return $"About page in {theme.GetColor()}";
        }
    }

    class Careers : IWebPage
    {
        protected ITheme theme;

        public Careers(ITheme theme)
        {
            this.theme = theme;
        }

        public string GetContent()
        {
            return $"Careers page in {theme.GetColor()}";
        }
    }

    interface ITheme
    {
        string GetColor();
    }

    class DarkTheme : ITheme
    {
        public string GetColor()
        {
            return "Dark Black";
        }
    }

    class LightTheme : ITheme
    {
        public string GetColor()
        {
            return "Off White";
        }
    }

    class AquaTheme : ITheme
    {
        public string GetColor()
        {
            return "Light blue";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AquaTheme aq = new AquaTheme();
            Home home = new Home(aq);

            DarkTheme dk = new DarkTheme();
            About about = new About(dk);

            LightTheme lt = new LightTheme();          
            Careers careers = new Careers(lt);

            Console.WriteLine(home.GetContent());
            Console.WriteLine(about.GetContent());
            Console.WriteLine(careers.GetContent()); 
        }
    }
}
