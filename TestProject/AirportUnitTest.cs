using PMDGTerminalX.Common;
using PMDGTerminalX.Geo;
using PMDGTerminalX.NavAid;
using Xunit;

namespace TerminalXTest
{
    public class AirportUnitTest
    {
        [Fact]
        public void TestFixParserForSFO()
        {
            Airport airport = new Airport();

            airport.Fixes.Add("ADDMM", new Fix("ADDMM", new GeoLocation("N 37 46.261667 W 121 42.515167", GeoStringFormat.DD)));
            airport.Fixes.Add("AFIVA", new Fix("AFIVA", new GeoLocation("N 37 46.41 W 122 22.5395", GeoStringFormat.DD)));
            airport.Fixes.Add("ALANN", new Fix("ALANN", new GeoLocation("N 35 35.8 W 125 56.4", GeoStringFormat.DD)));
            airport.Fixes.Add("ALCOA", new Fix("ALCOA", new GeoLocation("N 37 49.995167 W 125 50.0715", GeoStringFormat.DD)));
            airport.Fixes.Add("ALLBE", new Fix("ALLBE", new GeoLocation("N 37 30.383333 W 127 0", GeoStringFormat.DD)));
            airport.Fixes.Add("ALWYS", new Fix("ALWYS", new GeoLocation("N 37 38.005166 W 120 57.565834", GeoStringFormat.DD)));
            airport.Fixes.Add("AMAKR", new Fix("AMAKR", new GeoLocation("N 39 0 W 123 45", GeoStringFormat.DD)));
            airport.Fixes.Add("ANETE", new Fix("ANETE", new GeoLocation("N 37 27.824333 W 121 56.565167", GeoStringFormat.DD)));
            airport.Fixes.Add("ANJEE", new Fix("ANJEE", new GeoLocation("N 36 44.777167 W 121 57.8935", GeoStringFormat.DD)));
            airport.Fixes.Add("ARCHI", new Fix("ARCHI", new GeoLocation("N 37 29.447833 W 121 52.5325", GeoStringFormat.DD)));
            airport.Fixes.Add("ARGGG", new Fix("ARGGG", new GeoLocation("N 37 23.545333 W 122 16.897834", GeoStringFormat.DD)));
            airport.Fixes.Add("ARRTU", new Fix("ARRTU", new GeoLocation("N 37 44.017333 W 121 30.179333", GeoStringFormat.DD)));
            airport.Fixes.Add("AXMUL", new Fix("AXMUL", new GeoLocation("N 37 34.290833 W 122 15.431833", GeoStringFormat.DD)));
            airport.Fixes.Add("BAART", new Fix("BAART", new GeoLocation("N 36 27.716666 W 126 56", GeoStringFormat.DD)));
            airport.Fixes.Add("BARTN", new Fix("BARTN", new GeoLocation("N 37 32.906167 W 122 5.032834", GeoStringFormat.DD)));
            airport.Fixes.Add("BCEEE", new Fix("BCEEE", new GeoLocation("N 37 44.979 W 121 53.963666", GeoStringFormat.DD)));
            airport.Fixes.Add("BDEGA", new Fix("BDEGA", new GeoLocation("N 37 49.3815 W 122 35.532", GeoStringFormat.DD)));
            airport.Fixes.Add("BENET", new Fix("BENET", new GeoLocation("N 33 35.821333 W 118 50.51", GeoStringFormat.DD)));
            airport.Fixes.Add("BERKS", new Fix("BERKS", new GeoLocation("N 37 51.651667 W 122 12.700667", GeoStringFormat.DD)));
            airport.Fixes.Add("BGGLO", new Fix("BGGLO", new GeoLocation("N 38 13.475333 W 122 46.050334", GeoStringFormat.DD)));
            airport.Fixes.Add("BOLDR", new Fix("BOLDR", new GeoLocation("N 37 10.253167 W 122 4.57", GeoStringFormat.DD)));
            airport.Fixes.Add("BRINY", new Fix("BRINY", new GeoLocation("N 37 18.285667 W 122 39.699334", GeoStringFormat.DD)));
            airport.Fixes.Add("BRIXX", new Fix("BRIXX", new GeoLocation("N 37 37.070666 W 122 22.471667", GeoStringFormat.DD)));
            airport.Fixes.Add("BSR", new Fix("BSR", new GeoLocation("N 36 10.877666 W 121 38.526833", GeoStringFormat.DD)));
            airport.Fixes.Add("BYRON", new Fix("BYRON", new GeoLocation("N 37 49.371833 W 121 28.162166", GeoStringFormat.DD)));
            airport.Fixes.Add("CARME", new Fix("CARME", new GeoLocation("N 36 27.311 W 121 52.782833", GeoStringFormat.DD)));
            airport.Fixes.Add("CCR", new Fix("CCR", new GeoLocation("N 38 2.695166 W 122 2.7125", GeoStringFormat.DD)));
            airport.Fixes.Add("CEDES", new Fix("CEDES", new GeoLocation("N 37 33.049333 W 121 37.475167", GeoStringFormat.DD)));
            airport.Fixes.Add("CEPIN", new Fix("CEPIN", new GeoLocation("N 37 32.157167 W 122 10.3725", GeoStringFormat.DD)));
            airport.Fixes.Add("CFFKC", new Fix("CFFKC", new GeoLocation("N 37 37.011833 W 122 21.3805", GeoStringFormat.DD)));
            airport.Fixes.Add("CIITY", new Fix("CIITY", new GeoLocation("N 37 31.987 W 122 8.970667", GeoStringFormat.DD)));
            airport.Fixes.Add("CINNY", new Fix("CINNY", new GeoLocation("N 36 10.9 W 124 45.6", GeoStringFormat.DD)));
            airport.Fixes.Add("CISKO", new Fix("CISKO", new GeoLocation("N 35 41.850334 W 120 27.910667", GeoStringFormat.DD)));
            airport.Fixes.Add("COGGR", new Fix("COGGR", new GeoLocation("N 37 49.138834 W 121 58.568666", GeoStringFormat.DD)));
            airport.Fixes.Add("CORKK", new Fix("CORKK", new GeoLocation("N 37 44.015333 W 122 29.853", GeoStringFormat.DD)));
            airport.Fixes.Add("COSMC", new Fix("COSMC", new GeoLocation("N 37 49.563667 W 122 0.294", GeoStringFormat.DD)));
            airport.Fixes.Add("CYPRS", new Fix("CYPRS", new GeoLocation("N 36 25.340167 W 122 25.930834", GeoStringFormat.DD)));
            airport.Fixes.Add("CZQ", new Fix("CZQ", new GeoLocation("N 36 53.059333 W 119 48.908666", GeoStringFormat.DD)));
            airport.Fixes.Add("DAISY", new Fix("DAISY", new GeoLocation("N 34 15.5695 W 120 7.8755", GeoStringFormat.DD)));
            airport.Fixes.Add("DARNE", new Fix("DARNE", new GeoLocation("N 37 35.5965 W 122 17.5355", GeoStringFormat.DD)));
            airport.Fixes.Add("DEDHD", new Fix("DEDHD", new GeoLocation("N 38 20.131 W 122 6.7685", GeoStringFormat.DD)));
            airport.Fixes.Add("DEEAN", new Fix("DEEAN", new GeoLocation("N 38 20.949833 W 123 18.137333", GeoStringFormat.DD)));
            airport.Fixes.Add("DIVEC", new Fix("DIVEC", new GeoLocation("N 37 25.973 W 121 56.1005", GeoStringFormat.DD)));
            airport.Fixes.Add("DONNG", new Fix("DONNG", new GeoLocation("N 37 35.203 W 122 15.084", GeoStringFormat.DD)));
            airport.Fixes.Add("DOTNE", new Fix("DOTNE", new GeoLocation("N 37 43.119667 W 122 36.856", GeoStringFormat.DD)));
            airport.Fixes.Add("DUMBA", new Fix("DUMBA", new GeoLocation("N 37 30.211 W 122 5.768833", GeoStringFormat.DD)));
            airport.Fixes.Add("DUXBY", new Fix("DUXBY", new GeoLocation("N 37 41.752834 W 122 27.317167", GeoStringFormat.DD)));
            airport.Fixes.Add("DUYET", new Fix("DUYET", new GeoLocation("N 37 34.044 W 122 15.175667", GeoStringFormat.DD)));
            airport.Fixes.Add("DYAMD", new Fix("DYAMD", new GeoLocation("N 37 41.949667 W 120 24.265667", GeoStringFormat.DD)));
            airport.Fixes.Add("EBAYE", new Fix("EBAYE", new GeoLocation("N 35 52.123166 W 120 15.6335", GeoStringFormat.DD)));
            airport.Fixes.Add("EDDYY", new Fix("EDDYY", new GeoLocation("N 37 22.494167 W 122 7.125", GeoStringFormat.DD)));
            airport.Fixes.Add("ENI", new Fix("ENI", new GeoLocation("N 39 3.193 W 123 16.459667", GeoStringFormat.DD)));
            airport.Fixes.Add("EPICK", new Fix("EPICK", new GeoLocation("N 36 57.049333 W 121 57.160333", GeoStringFormat.DD)));
            airport.Fixes.Add("ESUME", new Fix("ESUME", new GeoLocation("N 37 44.832 W 122 17.424833", GeoStringFormat.DD)));
            airport.Fixes.Add("FABLA", new Fix("FABLA", new GeoLocation("N 37 35.843833 W 122 19.123667", GeoStringFormat.DD)));
            airport.Fixes.Add("FAITH", new Fix("FAITH", new GeoLocation("N 37 24.073 W 121 51.714", GeoStringFormat.DD)));
            airport.Fixes.Add("FATUS", new Fix("FATUS", new GeoLocation("N 37 29.154833 W 122 0.138167", GeoStringFormat.DD)));
            airport.Fixes.Add("FFOIL", new Fix("FFOIL", new GeoLocation("N 37 0.372167 W 122 33.851333", GeoStringFormat.DD)));
            airport.Fixes.Add("FLOWZ", new Fix("FLOWZ", new GeoLocation("N 37 35.551166 W 121 15.885", GeoStringFormat.DD)));
            airport.Fixes.Add("FLW", new Fix("FLW", new GeoLocation("N 35 5.585 W 119 51.934667", GeoStringFormat.DD)));
            airport.Fixes.Add("FMG", new Fix("FMG", new GeoLocation("N 39 31.876667 W 119 39.3645", GeoStringFormat.DD)));
            airport.Fixes.Add("FOBOT", new Fix("FOBOT", new GeoLocation("N 37 40.333834 W 122 20.415167", GeoStringFormat.DD)));
            airport.Fixes.Add("FOT", new Fix("FOT", new GeoLocation("N 40 40.2765 W 124 14.072167", GeoStringFormat.DD)));
            airport.Fixes.Add("FRELY", new Fix("FRELY", new GeoLocation("N 37 30.603167 W 121 47.7195", GeoStringFormat.DD)));
            airport.Fixes.Add("FRIGG", new Fix("FRIGG", new GeoLocation("N 37 27.9305 W 121 15.437333", GeoStringFormat.DD)));
            airport.Fixes.Add("GALOO", new Fix("GALOO", new GeoLocation("N 37 43.868833 W 122 19.873", GeoStringFormat.DD)));
            airport.Fixes.Add("GIRRR", new Fix("GIRRR", new GeoLocation("N 37 29.976 W 122 1.634167", GeoStringFormat.DD)));
            airport.Fixes.Add("GNNRR", new Fix("GNNRR", new GeoLocation("N 37 40.484666 W 122 30.203", GeoStringFormat.DD)));
            airport.Fixes.Add("GOBBS", new Fix("GOBBS", new GeoLocation("N 37 46.279 W 122 39.487166", GeoStringFormat.DD)));
            airport.Fixes.Add("GOBEC", new Fix("GOBEC", new GeoLocation("N 37 34.724 W 122 15.169667", GeoStringFormat.DD)));
            airport.Fixes.Add("GOWCH", new Fix("GOWCH", new GeoLocation("N 38 33.981833 W 122 43.141166", GeoStringFormat.DD)));
            airport.Fixes.Add("GROAN", new Fix("GROAN", new GeoLocation("N 37 35.419166 W 121 17.104667", GeoStringFormat.DD)));
            airport.Fixes.Add("GRTFL", new Fix("GRTFL", new GeoLocation("N 38 21.130166 W 122 13.888166", GeoStringFormat.DD)));
            airport.Fixes.Add("GUTTS", new Fix("GUTTS", new GeoLocation("N 37 32.797333 W 122 9.356333", GeoStringFormat.DD)));
            airport.Fixes.Add("GVO", new Fix("GVO", new GeoLocation("N 34 31.879166 W 120 5.465333", GeoStringFormat.DD)));
            airport.Fixes.Add("HADLY", new Fix("HADLY", new GeoLocation("N 37 24.1415 W 122 34.5355", GeoStringFormat.DD)));
            airport.Fixes.Add("HAIRE", new Fix("HAIRE", new GeoLocation("N 37 54.428167 W 121 28.822667", GeoStringFormat.DD)));
            airport.Fixes.Add("HEFLY", new Fix("HEFLY", new GeoLocation("N 37 40.963333 W 121 13.493666", GeoStringFormat.DD)));
            airport.Fixes.Add("HEGOT", new Fix("HEGOT", new GeoLocation("N 37 30.483667 W 122 3.713333", GeoStringFormat.DD)));
            airport.Fixes.Add("HEMAN", new Fix("HEMAN", new GeoLocation("N 37 32.031 W 122 10.4", GeoStringFormat.DD)));
            airport.Fixes.Add("HITOD", new Fix("HITOD", new GeoLocation("N 37 51.849833 W 122 12.743833", GeoStringFormat.DD)));
            airport.Fixes.Add("HOPII", new Fix("HOPII", new GeoLocation("N 37 26.044333 W 121 50.104667", GeoStringFormat.DD)));
            airport.Fixes.Add("HUNTS", new Fix("HUNTS", new GeoLocation("N 36 55.75 W 123 34", GeoStringFormat.DD)));
            airport.Fixes.Add("HUSSH", new Fix("HUSSH", new GeoLocation("N 37 44.97 W 122 20.3155", GeoStringFormat.DD)));
            airport.Fixes.Add("HYPEE", new Fix("HYPEE", new GeoLocation("N 37 52.814666 W 122 4.049", GeoStringFormat.DD)));
            airport.Fixes.Add("IGUKE", new Fix("IGUKE", new GeoLocation("N 37 34.2 W 122 15.546167", GeoStringFormat.DD)));
            airport.Fixes.Add("ILA", new Fix("ILA", new GeoLocation("N 39 4.2705 W 122 1.636166", GeoStringFormat.DD)));
            airport.Fixes.Add("INYOE", new Fix("INYOE", new GeoLocation("N 37 53.737333 W 118 45.8995", GeoStringFormat.DD)));
            airport.Fixes.Add("JAYKK", new Fix("JAYKK", new GeoLocation("N 38 3.391834 W 122 15.709166", GeoStringFormat.DD)));
            airport.Fixes.Add("JONNE", new Fix("JONNE", new GeoLocation("N 38 33.0625 W 122 51.7965", GeoStringFormat.DD)));
            airport.Fixes.Add("JOSUF", new Fix("JOSUF", new GeoLocation("N 37 35.527667 W 122 17.133", GeoStringFormat.DD)));
            airport.Fixes.Add("JULOS", new Fix("JULOS", new GeoLocation("N 37 40.260833 W 122 29.999333", GeoStringFormat.DD)));
            airport.Fixes.Add("KATFH", new Fix("KATFH", new GeoLocation("N 37 27.128833 W 122 2.847167", GeoStringFormat.DD)));
            airport.Fixes.Add("KAYEX", new Fix("KAYEX", new GeoLocation("N 36 29.249167 W 120 56.8715", GeoStringFormat.DD)));
            airport.Fixes.Add("KRLOS", new Fix("KRLOS", new GeoLocation("N 37 48.269333 W 122 31.707", GeoStringFormat.DD)));
            airport.Fixes.Add("KSFO", new Fix("KSFO", new GeoLocation("N 37 37.128334 W 122 22.525", GeoStringFormat.DD)));
            airport.Fixes.Add("KTINA", new Fix("KTINA", new GeoLocation("N 36 23.06 W 121 9.810334", GeoStringFormat.DD)));
            airport.Fixes.Add("KYLLA", new Fix("KYLLA", new GeoLocation("N 37 49.564667 W 119 22.091666", GeoStringFormat.DD)));
            airport.Fixes.Add("KYNNG", new Fix("KYNNG", new GeoLocation("N 37 40.956 W 122 31.425", GeoStringFormat.DD)));
            airport.Fixes.Add("LAANE", new Fix("LAANE", new GeoLocation("N 37 39.539 W 120 44.8435", GeoStringFormat.DD)));
            airport.Fixes.Add("LEEFF", new Fix("LEEFF", new GeoLocation("N 37 36.519833 W 121 7.441667", GeoStringFormat.DD)));
            airport.Fixes.Add("LEGGS", new Fix("LEGGS", new GeoLocation("N 39 20.1975 W 121 5.745833", GeoStringFormat.DD)));
            airport.Fixes.Add("LETHH", new Fix("LETHH", new GeoLocation("N 38 37.2905 W 123 8.675167", GeoStringFormat.DD)));
            airport.Fixes.Add("LIBBO", new Fix("LIBBO", new GeoLocation("N 36 0 W 121 50", GeoStringFormat.DD)));
            airport.Fixes.Add("LLVII", new Fix("LLVII", new GeoLocation("N 37 42.025834 W 121 46.749833", GeoStringFormat.DD)));
            airport.Fixes.Add("LNNDA", new Fix("LNNDA", new GeoLocation("N 37 28.933333 W 120 26.65", GeoStringFormat.DD)));
            airport.Fixes.Add("LOSHN", new Fix("LOSHN", new GeoLocation("N 35 50.8565 W 120 0.0285", GeoStringFormat.DD)));
            airport.Fixes.Add("LOZIT", new Fix("LOZIT", new GeoLocation("N 37 53.9595 W 122 40.391666", GeoStringFormat.DD)));
            airport.Fixes.Add("MAAYS", new Fix("MAAYS", new GeoLocation("N 37 29.027833 W 122 8.8695", GeoStringFormat.DD)));
            airport.Fixes.Add("MCKEY", new Fix("MCKEY", new GeoLocation("N 35 28.985666 W 121 4.988333", GeoStringFormat.DD)));
            airport.Fixes.Add("MCOVY", new Fix("MCOVY", new GeoLocation("N 37 21.330167 W 122 0.815666", GeoStringFormat.DD)));
            airport.Fixes.Add("MDBAY", new Fix("MDBAY", new GeoLocation("N 37 41.0865 W 122 18.216334", GeoStringFormat.DD)));
            airport.Fixes.Add("MEHTA", new Fix("MEHTA", new GeoLocation("N 37 27.7015 W 121 59.7915", GeoStringFormat.DD)));
            airport.Fixes.Add("MENLO", new Fix("MENLO", new GeoLocation("N 37 27.821167 W 122 9.2195", GeoStringFormat.DD)));
            airport.Fixes.Add("MIUKE", new Fix("MIUKE", new GeoLocation("N 37 33.136 W 122 10.870834", GeoStringFormat.DD)));
            airport.Fixes.Add("MLBEC", new Fix("MLBEC", new GeoLocation("N 38 52.486333 W 122 57.539333", GeoStringFormat.DD)));
            airport.Fixes.Add("MOD", new Fix("MOD", new GeoLocation("N 37 37.6425 W 120 57.472", GeoStringFormat.DD)));
            airport.Fixes.Add("MOGEE", new Fix("MOGEE", new GeoLocation("N 38 20.166667 W 121 23.383333", GeoStringFormat.DD)));
            airport.Fixes.Add("MOLEN", new Fix("MOLEN", new GeoLocation("N 37 59.872333 W 123 5.207833", GeoStringFormat.DD)));
            airport.Fixes.Add("MOVDD", new Fix("MOVDD", new GeoLocation("N 37 39.681334 W 121 26.892167", GeoStringFormat.DD)));
            airport.Fixes.Add("MQO", new Fix("MQO", new GeoLocation("N 35 15.135334 W 120 45.574", GeoStringFormat.DD)));
            airport.Fixes.Add("MRRLO", new Fix("MRRLO", new GeoLocation("N 38 53.852833 W 122 34.694", GeoStringFormat.DD)));
            airport.Fixes.Add("MSCAT", new Fix("MSCAT", new GeoLocation("N 38 34.001833 W 122 40.3", GeoStringFormat.DD)));
            airport.Fixes.Add("MVA", new Fix("MVA", new GeoLocation("N 38 33.918 W 118 1.971167", GeoStringFormat.DD)));
            airport.Fixes.Add("MVRKK", new Fix("MVRKK", new GeoLocation("N 37 44.218333 W 122 27.267", GeoStringFormat.DD)));
            airport.Fixes.Add("NARWL", new Fix("NARWL", new GeoLocation("N 37 16.486834 W 122 4.757666", GeoStringFormat.DD)));
            airport.Fixes.Add("NEPIC", new Fix("NEPIC", new GeoLocation("N 37 35.153666 W 122 17.813", GeoStringFormat.DD)));
            airport.Fixes.Add("NIITE", new Fix("NIITE", new GeoLocation("N 37 50.7145 W 122 23.212166", GeoStringFormat.DD)));
            airport.Fixes.Add("NORMM", new Fix("NORMM", new GeoLocation("N 37 43.2125 W 122 36.790333", GeoStringFormat.DD)));
            airport.Fixes.Add("NRRLI", new Fix("NRRLI", new GeoLocation("N 36 29.736 W 121 41.964", GeoStringFormat.DD)));
            airport.Fixes.Add("NTELL", new Fix("NTELL", new GeoLocation("N 36 53.983166 W 119 53.370167", GeoStringFormat.DD)));
            airport.Fixes.Add("OAK", new Fix("OAK", new GeoLocation("N 37 43.555333 W 122 13.415167", GeoStringFormat.DD)));
            airport.Fixes.Add("OAL", new Fix("OAL", new GeoLocation("N 38 0.195667 W 117 46.226833", GeoStringFormat.DD)));
            airport.Fixes.Add("OLYMM", new Fix("OLYMM", new GeoLocation("N 37 42.961667 W 122 40.361333", GeoStringFormat.DD)));
            airport.Fixes.Add("OOWEN", new Fix("OOWEN", new GeoLocation("N 37 42.4195 W 121 16.486834", GeoStringFormat.DD)));
            airport.Fixes.Add("ORRCA", new Fix("ORRCA", new GeoLocation("N 38 26.6195 W 121 33.097333", GeoStringFormat.DD)));
            airport.Fixes.Add("ORYAN", new Fix("ORYAN", new GeoLocation("N 37 36.295333 W 122 20.196667", GeoStringFormat.DD)));
            airport.Fixes.Add("OSI", new Fix("OSI", new GeoLocation("N 37 23.55 W 122 16.878167", GeoStringFormat.DD)));
            airport.Fixes.Add("PAINT", new Fix("PAINT", new GeoLocation("N 38 0 W 125 30", GeoStringFormat.DD)));
            airport.Fixes.Add("PASIF", new Fix("PASIF", new GeoLocation("N 37 11.633333 W 123 8", GeoStringFormat.DD)));
            airport.Fixes.Add("PEENO", new Fix("PEENO", new GeoLocation("N 38 34.2155 W 123 36.932", GeoStringFormat.DD)));
            airport.Fixes.Add("PIRAT", new Fix("PIRAT", new GeoLocation("N 37 15.459 W 122 51.801167", GeoStringFormat.DD)));
            airport.Fixes.Add("PONKE", new Fix("PONKE", new GeoLocation("N 37 27.529 W 121 59.763167", GeoStringFormat.DD)));
            airport.Fixes.Add("POPES", new Fix("POPES", new GeoLocation("N 38 29.156833 W 122 20.752667", GeoStringFormat.DD)));
            airport.Fixes.Add("PORTE", new Fix("PORTE", new GeoLocation("N 37 29.387167 W 122 28.474667", GeoStringFormat.DD)));
            airport.Fixes.Add("PYE", new Fix("PYE", new GeoLocation("N 38 4.785334 W 122 52.069667", GeoStringFormat.DD)));
            airport.Fixes.Add("PYLLE", new Fix("PYLLE", new GeoLocation("N 38 27.2 W 122 25.719", GeoStringFormat.DD)));
            airport.Fixes.Add("QUINN", new Fix("QUINN", new GeoLocation("N 38 28.797167 W 123 5.289", GeoStringFormat.DD)));
            airport.Fixes.Add("RBG", new Fix("RBG", new GeoLocation("N 43 10.945333 W 123 21.134333", GeoStringFormat.DD)));
            airport.Fixes.Add("RBL", new Fix("RBL", new GeoLocation("N 40 5.934667 W 122 14.181", GeoStringFormat.DD)));
            airport.Fixes.Add("REBAS", new Fix("REBAS", new GeoLocation("N 37 56.441 W 122 23.02", GeoStringFormat.DD)));
            airport.Fixes.Add("RISTI", new Fix("RISTI", new GeoLocation("N 37 36.4875 W 121 31.996667", GeoStringFormat.DD)));
            airport.Fixes.Add("ROGGE", new Fix("ROGGE", new GeoLocation("N 37 42.510167 W 122 18.793", GeoStringFormat.DD)));
            airport.Fixes.Add("ROKME", new Fix("ROKME", new GeoLocation("N 37 30.6355 W 122 7.0965", GeoStringFormat.DD)));
            airport.Fixes.Add("RUSME", new Fix("RUSME", new GeoLocation("N 37 29.65 W 117 31.2", GeoStringFormat.DD)));
            airport.Fixes.Add("RZS", new Fix("RZS", new GeoLocation("N 34 30.572 W 119 46.2595", GeoStringFormat.DD)));
            airport.Fixes.Add("SAC", new Fix("SAC", new GeoLocation("N 38 26.624333 W 121 33.099167", GeoStringFormat.DD)));
            airport.Fixes.Add("SAHEY", new Fix("SAHEY", new GeoLocation("N 37 34.107 W 122 14.673334", GeoStringFormat.DD)));
            airport.Fixes.Add("SEGUL", new Fix("SEGUL", new GeoLocation("N 36 57.782167 W 122 34.327834", GeoStringFormat.DD)));
            airport.Fixes.Add("SENZY", new Fix("SENZY", new GeoLocation("N 37 39.99 W 122 29.11", GeoStringFormat.DD)));
            airport.Fixes.Add("SEPDY", new Fix("SEPDY", new GeoLocation("N 37 41.14 W 122 21.82", GeoStringFormat.DD)));
            airport.Fixes.Add("SERFR", new Fix("SERFR", new GeoLocation("N 36 4.098334 W 121 21.879833", GeoStringFormat.DD)));
            airport.Fixes.Add("SFO", new Fix("SFO", new GeoLocation("N 37 37.169167 W 122 22.433666", GeoStringFormat.DD)));
            airport.Fixes.Add("SHAKE", new Fix("SHAKE", new GeoLocation("N 37 45.242333 W 122 16.975333", GeoStringFormat.DD)));
            airport.Fixes.Add("SIDBY", new Fix("SIDBY", new GeoLocation("N 37 27.042667 W 122 8.684833", GeoStringFormat.DD)));
            airport.Fixes.Add("SIPLY", new Fix("SIPLY", new GeoLocation("N 37 35.12 W 122 14.01", GeoStringFormat.DD)));
            airport.Fixes.Add("SKUNK", new Fix("SKUNK", new GeoLocation("N 37 0.455666 W 122 1.993667", GeoStringFormat.DD)));
            airport.Fixes.Add("SNORA", new Fix("SNORA", new GeoLocation("N 37 38.733334 W 119 48.377666", GeoStringFormat.DD)));
            airport.Fixes.Add("SNTNA", new Fix("SNTNA", new GeoLocation("N 37 50.267167 W 122 26.054333", GeoStringFormat.DD)));
            airport.Fixes.Add("SOOIE", new Fix("SOOIE", new GeoLocation("N 37 25.714333 W 121 36.458333", GeoStringFormat.DD)));
            airport.Fixes.Add("SSTIK", new Fix("SSTIK", new GeoLocation("N 37 40.700666 W 122 21.6995", GeoStringFormat.DD)));
            airport.Fixes.Add("STINS", new Fix("STINS", new GeoLocation("N 37 49.420667 W 122 45.401", GeoStringFormat.DD)));
            airport.Fixes.Add("STLER", new Fix("STLER", new GeoLocation("N 37 42.081833 W 122 42.663833", GeoStringFormat.DD)));
            airport.Fixes.Add("SUPER", new Fix("SUPER", new GeoLocation("N 37 18.159833 W 123 48.781166", GeoStringFormat.DD)));
            airport.Fixes.Add("SUSEY", new Fix("SUSEY", new GeoLocation("N 36 25.947833 W 121 3.799834", GeoStringFormat.DD)));
            airport.Fixes.Add("SXC", new Fix("SXC", new GeoLocation("N 33 22.503334 W 118 25.194667", GeoStringFormat.DD)));
            airport.Fixes.Add("SYRAH", new Fix("SYRAH", new GeoLocation("N 37 59.463 W 121 6.185333", GeoStringFormat.DD)));
            airport.Fixes.Add("TAMMM", new Fix("TAMMM", new GeoLocation("N 37 59.2905 W 122 8.874667", GeoStringFormat.DD)));
            airport.Fixes.Add("THEEZ", new Fix("THEEZ", new GeoLocation("N 37 30.208166 W 122 25.485167", GeoStringFormat.DD)));
            airport.Fixes.Add("TIPRE", new Fix("TIPRE", new GeoLocation("N 38 12.35 W 121 2.15", GeoStringFormat.DD)));
            airport.Fixes.Add("TRACY", new Fix("TRACY", new GeoLocation("N 37 43.886333 W 121 27.558167", GeoStringFormat.DD)));
            airport.Fixes.Add("TROSE", new Fix("TROSE", new GeoLocation("N 37 41.949667 W 120 24.253333", GeoStringFormat.DD)));
            airport.Fixes.Add("TRUKN", new Fix("TRUKN", new GeoLocation("N 37 43.0535 W 122 12.875333", GeoStringFormat.DD)));
            airport.Fixes.Add("TYDYE", new Fix("TYDYE", new GeoLocation("N 37 41.359166 W 122 16.136666", GeoStringFormat.DD)));
            airport.Fixes.Add("UPEND", new Fix("UPEND", new GeoLocation("N 38 1.919 W 122 5.824", GeoStringFormat.DD)));
            airport.Fixes.Add("URRSA", new Fix("URRSA", new GeoLocation("N 37 36.186667 W 122 20.2705", GeoStringFormat.DD)));
            airport.Fixes.Add("UTOOB", new Fix("UTOOB", new GeoLocation("N 37 24.695833 W 122 20.333", GeoStringFormat.DD)));
            airport.Fixes.Add("VIKYU", new Fix("VIKYU", new GeoLocation("N 37 42.810667 W 122 35.772334", GeoStringFormat.DD)));
            airport.Fixes.Add("WAMMY", new Fix("WAMMY", new GeoLocation("N 37 32.463833 W 122 43.443334", GeoStringFormat.DD)));
            airport.Fixes.Add("WASOP", new Fix("WASOP", new GeoLocation("N 37 31.810667 W 122 7.291", GeoStringFormat.DD)));
            airport.Fixes.Add("WESLA", new Fix("WESLA", new GeoLocation("N 37 39.862333 W 122 28.8175", GeoStringFormat.DD)));
            airport.Fixes.Add("WETOR", new Fix("WETOR", new GeoLocation("N 37 29.083166 W 122 3.4285", GeoStringFormat.DD)));
            airport.Fixes.Add("WIBNI", new Fix("WIBNI", new GeoLocation("N 37 31.003166 W 122 1.881833", GeoStringFormat.DD)));
            airport.Fixes.Add("WPOUT", new Fix("WPOUT", new GeoLocation("N 37 7.169167 W 122 17.5645", GeoStringFormat.DD)));
            airport.Fixes.Add("WUSES", new Fix("WUSES", new GeoLocation("N 37 39.347833 W 124 0.098", GeoStringFormat.DD)));
            airport.Fixes.Add("WWAVS", new Fix("WWAVS", new GeoLocation("N 36 44.491834 W 121 53.654", GeoStringFormat.DD)));
            airport.Fixes.Add("XATTU", new Fix("XATTU", new GeoLocation("N 37 40.271333 W 122 29.689667", GeoStringFormat.DD)));
            airport.Fixes.Add("YOSEM", new Fix("YOSEM", new GeoLocation("N 37 45.7645 W 118 45.996667", GeoStringFormat.DD)));
            airport.Fixes.Add("YYUNG", new Fix("YYUNG", new GeoLocation("N 35 30.965 W 121 4.121167", GeoStringFormat.DD)));
            airport.Fixes.Add("ZILED", new Fix("ZILED", new GeoLocation("N 37 29.7375 W 121 57.492667", GeoStringFormat.DD)));
            airport.Fixes.Add("ZOMER", new Fix("ZOMER", new GeoLocation("N 37 32.720833 W 120 37.8865", GeoStringFormat.DD)));

            string expectedValue = "FIXES\n"
+ "FIX ADDMM LATLON N 37 46.261667 W 121 42.515167\n"
+ "FIX AFIVA LATLON N 37 46.41 W 122 22.5395\n"
+ "FIX ALANN LATLON N 35 35.8 W 125 56.4\n"
+ "FIX ALCOA LATLON N 37 49.995167 W 125 50.0715\n"
+ "FIX ALLBE LATLON N 37 30.383333 W 127 0\n"
+ "FIX ALWYS LATLON N 37 38.005166 W 120 57.565834\n"
+ "FIX AMAKR LATLON N 39 0 W 123 45\n"
+ "FIX ANETE LATLON N 37 27.824333 W 121 56.565167\n"
+ "FIX ANJEE LATLON N 36 44.777167 W 121 57.8935\n"
+ "FIX ARCHI LATLON N 37 29.447833 W 121 52.5325\n"
+ "FIX ARGGG LATLON N 37 23.545333 W 122 16.897834\n"
+ "FIX ARRTU LATLON N 37 44.017333 W 121 30.179333\n"
+ "FIX AXMUL LATLON N 37 34.290833 W 122 15.431833\n"
+ "FIX BAART LATLON N 36 27.716666 W 126 56\n"
+ "FIX BARTN LATLON N 37 32.906167 W 122 5.032834\n"
+ "FIX BCEEE LATLON N 37 44.979 W 121 53.963666\n"
+ "FIX BDEGA LATLON N 37 49.3815 W 122 35.532\n"
+ "FIX BENET LATLON N 33 35.821333 W 118 50.51\n"
+ "FIX BERKS LATLON N 37 51.651667 W 122 12.700667\n"
+ "FIX BGGLO LATLON N 38 13.475333 W 122 46.050334\n"
+ "FIX BOLDR LATLON N 37 10.253167 W 122 4.57\n"
+ "FIX BRINY LATLON N 37 18.285667 W 122 39.699334\n"
+ "FIX BRIXX LATLON N 37 37.070666 W 122 22.471667\n"
+ "FIX BSR LATLON N 36 10.877666 W 121 38.526833\n"
+ "FIX BYRON LATLON N 37 49.371833 W 121 28.162166\n"
+ "FIX CARME LATLON N 36 27.311 W 121 52.782833\n"
+ "FIX CCR LATLON N 38 2.695166 W 122 2.7125\n"
+ "FIX CEDES LATLON N 37 33.049333 W 121 37.475167\n"
+ "FIX CEPIN LATLON N 37 32.157167 W 122 10.3725\n"
+ "FIX CFFKC LATLON N 37 37.011833 W 122 21.3805\n"
+ "FIX CIITY LATLON N 37 31.987 W 122 8.970667\n"
+ "FIX CINNY LATLON N 36 10.9 W 124 45.6\n"
+ "FIX CISKO LATLON N 35 41.850334 W 120 27.910667\n"
+ "FIX COGGR LATLON N 37 49.138834 W 121 58.568666\n"
+ "FIX CORKK LATLON N 37 44.015333 W 122 29.853\n"
+ "FIX COSMC LATLON N 37 49.563667 W 122 0.294\n"
+ "FIX CYPRS LATLON N 36 25.340167 W 122 25.930834\n"
+ "FIX CZQ LATLON N 36 53.059333 W 119 48.908666\n"
+ "FIX DAISY LATLON N 34 15.5695 W 120 7.8755\n"
+ "FIX DARNE LATLON N 37 35.5965 W 122 17.5355\n"
+ "FIX DEDHD LATLON N 38 20.131 W 122 6.7685\n"
+ "FIX DEEAN LATLON N 38 20.949833 W 123 18.137333\n"
+ "FIX DIVEC LATLON N 37 25.973 W 121 56.1005\n"
+ "FIX DONNG LATLON N 37 35.203 W 122 15.084\n"
+ "FIX DOTNE LATLON N 37 43.119667 W 122 36.856\n"
+ "FIX DUMBA LATLON N 37 30.211 W 122 5.768833\n"
+ "FIX DUXBY LATLON N 37 41.752834 W 122 27.317167\n"
+ "FIX DUYET LATLON N 37 34.044 W 122 15.175667\n"
+ "FIX DYAMD LATLON N 37 41.949667 W 120 24.265667\n"
+ "FIX EBAYE LATLON N 35 52.123166 W 120 15.6335\n"
+ "FIX EDDYY LATLON N 37 22.494167 W 122 7.125\n"
+ "FIX ENI LATLON N 39 3.193 W 123 16.459667\n"
+ "FIX EPICK LATLON N 36 57.049333 W 121 57.160333\n"
+ "FIX ESUME LATLON N 37 44.832 W 122 17.424833\n"
+ "FIX FABLA LATLON N 37 35.843833 W 122 19.123667\n"
+ "FIX FAITH LATLON N 37 24.073 W 121 51.714\n"
+ "FIX FATUS LATLON N 37 29.154833 W 122 0.138167\n"
+ "FIX FFOIL LATLON N 37 0.372167 W 122 33.851333\n"
+ "FIX FLOWZ LATLON N 37 35.551166 W 121 15.885\n"
+ "FIX FLW LATLON N 35 5.585 W 119 51.934667\n"
+ "FIX FMG LATLON N 39 31.876667 W 119 39.3645\n"
+ "FIX FOBOT LATLON N 37 40.333834 W 122 20.415167\n"
+ "FIX FOT LATLON N 40 40.2765 W 124 14.072167\n"
+ "FIX FRELY LATLON N 37 30.603167 W 121 47.7195\n"
+ "FIX FRIGG LATLON N 37 27.9305 W 121 15.437333\n"
+ "FIX GALOO LATLON N 37 43.868833 W 122 19.873\n"
+ "FIX GIRRR LATLON N 37 29.976 W 122 1.634167\n"
+ "FIX GNNRR LATLON N 37 40.484666 W 122 30.203\n"
+ "FIX GOBBS LATLON N 37 46.279 W 122 39.487166\n"
+ "FIX GOBEC LATLON N 37 34.724 W 122 15.169667\n"
+ "FIX GOWCH LATLON N 38 33.981833 W 122 43.141166\n"
+ "FIX GROAN LATLON N 37 35.419166 W 121 17.104667\n"
+ "FIX GRTFL LATLON N 38 21.130166 W 122 13.888166\n"
+ "FIX GUTTS LATLON N 37 32.797333 W 122 9.356333\n"
+ "FIX GVO LATLON N 34 31.879166 W 120 5.465333\n"
+ "FIX HADLY LATLON N 37 24.1415 W 122 34.5355\n"
+ "FIX HAIRE LATLON N 37 54.428167 W 121 28.822667\n"
+ "FIX HEFLY LATLON N 37 40.963333 W 121 13.493666\n"
+ "FIX HEGOT LATLON N 37 30.483667 W 122 3.713333\n"
+ "FIX HEMAN LATLON N 37 32.031 W 122 10.4\n"
+ "FIX HITOD LATLON N 37 51.849833 W 122 12.743833\n"
+ "FIX HOPII LATLON N 37 26.044333 W 121 50.104667\n"
+ "FIX HUNTS LATLON N 36 55.75 W 123 34\n"
+ "FIX HUSSH LATLON N 37 44.97 W 122 20.3155\n"
+ "FIX HYPEE LATLON N 37 52.814666 W 122 4.049\n"
+ "FIX IGUKE LATLON N 37 34.2 W 122 15.546167\n"
+ "FIX ILA LATLON N 39 4.2705 W 122 1.636166\n"
+ "FIX INYOE LATLON N 37 53.737333 W 118 45.8995\n"
+ "FIX JAYKK LATLON N 38 3.391834 W 122 15.709166\n"
+ "FIX JONNE LATLON N 38 33.0625 W 122 51.7965\n"
+ "FIX JOSUF LATLON N 37 35.527667 W 122 17.133\n"
+ "FIX JULOS LATLON N 37 40.260833 W 122 29.999333\n"
+ "FIX KATFH LATLON N 37 27.128833 W 122 2.847167\n"
+ "FIX KAYEX LATLON N 36 29.249167 W 120 56.8715\n"
+ "FIX KRLOS LATLON N 37 48.269333 W 122 31.707\n"
+ "FIX KSFO LATLON N 37 37.128334 W 122 22.525\n"
+ "FIX KTINA LATLON N 36 23.06 W 121 9.810334\n"
+ "FIX KYLLA LATLON N 37 49.564667 W 119 22.091666\n"
+ "FIX KYNNG LATLON N 37 40.956 W 122 31.425\n"
+ "FIX LAANE LATLON N 37 39.539 W 120 44.8435\n"
+ "FIX LEEFF LATLON N 37 36.519833 W 121 7.441667\n"
+ "FIX LEGGS LATLON N 39 20.1975 W 121 5.745833\n"
+ "FIX LETHH LATLON N 38 37.2905 W 123 8.675167\n"
+ "FIX LIBBO LATLON N 36 0 W 121 50\n"
+ "FIX LLVII LATLON N 37 42.025834 W 121 46.749833\n"
+ "FIX LNNDA LATLON N 37 28.933333 W 120 26.65\n"
+ "FIX LOSHN LATLON N 35 50.8565 W 120 0.0285\n"
+ "FIX LOZIT LATLON N 37 53.9595 W 122 40.391666\n"
+ "FIX MAAYS LATLON N 37 29.027833 W 122 8.8695\n"
+ "FIX MCKEY LATLON N 35 28.985666 W 121 4.988333\n"
+ "FIX MCOVY LATLON N 37 21.330167 W 122 0.815666\n"
+ "FIX MDBAY LATLON N 37 41.0865 W 122 18.216334\n"
+ "FIX MEHTA LATLON N 37 27.7015 W 121 59.7915\n"
+ "FIX MENLO LATLON N 37 27.821167 W 122 9.2195\n"
+ "FIX MIUKE LATLON N 37 33.136 W 122 10.870834\n"
+ "FIX MLBEC LATLON N 38 52.486333 W 122 57.539333\n"
+ "FIX MOD LATLON N 37 37.6425 W 120 57.472\n"
+ "FIX MOGEE LATLON N 38 20.166667 W 121 23.383333\n"
+ "FIX MOLEN LATLON N 37 59.872333 W 123 5.207833\n"
+ "FIX MOVDD LATLON N 37 39.681334 W 121 26.892167\n"
+ "FIX MQO LATLON N 35 15.135334 W 120 45.574\n"
+ "FIX MRRLO LATLON N 38 53.852833 W 122 34.694\n"
+ "FIX MSCAT LATLON N 38 34.001833 W 122 40.3\n"
+ "FIX MVA LATLON N 38 33.918 W 118 1.971167\n"
+ "FIX MVRKK LATLON N 37 44.218333 W 122 27.267\n"
+ "FIX NARWL LATLON N 37 16.486834 W 122 4.757666\n"
+ "FIX NEPIC LATLON N 37 35.153666 W 122 17.813\n"
+ "FIX NIITE LATLON N 37 50.7145 W 122 23.212166\n"
+ "FIX NORMM LATLON N 37 43.2125 W 122 36.790333\n"
+ "FIX NRRLI LATLON N 36 29.736 W 121 41.964\n"
+ "FIX NTELL LATLON N 36 53.983166 W 119 53.370167\n"
+ "FIX OAK LATLON N 37 43.555333 W 122 13.415167\n"
+ "FIX OAL LATLON N 38 0.195667 W 117 46.226833\n"
+ "FIX OLYMM LATLON N 37 42.961667 W 122 40.361333\n"
+ "FIX OOWEN LATLON N 37 42.4195 W 121 16.486834\n"
+ "FIX ORRCA LATLON N 38 26.6195 W 121 33.097333\n"
+ "FIX ORYAN LATLON N 37 36.295333 W 122 20.196667\n"
+ "FIX OSI LATLON N 37 23.55 W 122 16.878167\n"
+ "FIX PAINT LATLON N 38 0 W 125 30\n"
+ "FIX PASIF LATLON N 37 11.633333 W 123 8\n"
+ "FIX PEENO LATLON N 38 34.2155 W 123 36.932\n"
+ "FIX PIRAT LATLON N 37 15.459 W 122 51.801167\n"
+ "FIX PONKE LATLON N 37 27.529 W 121 59.763167\n"
+ "FIX POPES LATLON N 38 29.156833 W 122 20.752667\n"
+ "FIX PORTE LATLON N 37 29.387167 W 122 28.474667\n"
+ "FIX PYE LATLON N 38 4.785334 W 122 52.069667\n"
+ "FIX PYLLE LATLON N 38 27.2 W 122 25.719\n"
+ "FIX QUINN LATLON N 38 28.797167 W 123 5.289\n"
+ "FIX RBG LATLON N 43 10.945333 W 123 21.134333\n"
+ "FIX RBL LATLON N 40 5.934667 W 122 14.181\n"
+ "FIX REBAS LATLON N 37 56.441 W 122 23.02\n"
+ "FIX RISTI LATLON N 37 36.4875 W 121 31.996667\n"
+ "FIX ROGGE LATLON N 37 42.510167 W 122 18.793\n"
+ "FIX ROKME LATLON N 37 30.6355 W 122 7.0965\n"
+ "FIX RUSME LATLON N 37 29.65 W 117 31.2\n"
+ "FIX RZS LATLON N 34 30.572 W 119 46.2595\n"
+ "FIX SAC LATLON N 38 26.624333 W 121 33.099167\n"
+ "FIX SAHEY LATLON N 37 34.107 W 122 14.673334\n"
+ "FIX SEGUL LATLON N 36 57.782167 W 122 34.327834\n"
+ "FIX SENZY LATLON N 37 39.99 W 122 29.11\n"
+ "FIX SEPDY LATLON N 37 41.14 W 122 21.82\n"
+ "FIX SERFR LATLON N 36 4.098334 W 121 21.879833\n"
+ "FIX SFO LATLON N 37 37.169167 W 122 22.433666\n"
+ "FIX SHAKE LATLON N 37 45.242333 W 122 16.975333\n"
+ "FIX SIDBY LATLON N 37 27.042667 W 122 8.684833\n"
+ "FIX SIPLY LATLON N 37 35.12 W 122 14.01\n"
+ "FIX SKUNK LATLON N 37 0.455666 W 122 1.993667\n"
+ "FIX SNORA LATLON N 37 38.733334 W 119 48.377666\n"
+ "FIX SNTNA LATLON N 37 50.267167 W 122 26.054333\n"
+ "FIX SOOIE LATLON N 37 25.714333 W 121 36.458333\n"
+ "FIX SSTIK LATLON N 37 40.700666 W 122 21.6995\n"
+ "FIX STINS LATLON N 37 49.420667 W 122 45.401\n"
+ "FIX STLER LATLON N 37 42.081833 W 122 42.663833\n"
+ "FIX SUPER LATLON N 37 18.159833 W 123 48.781166\n"
+ "FIX SUSEY LATLON N 36 25.947833 W 121 3.799834\n"
+ "FIX SXC LATLON N 33 22.503334 W 118 25.194667\n"
+ "FIX SYRAH LATLON N 37 59.463 W 121 6.185333\n"
+ "FIX TAMMM LATLON N 37 59.2905 W 122 8.874667\n"
+ "FIX THEEZ LATLON N 37 30.208166 W 122 25.485167\n"
+ "FIX TIPRE LATLON N 38 12.35 W 121 2.15\n"
+ "FIX TRACY LATLON N 37 43.886333 W 121 27.558167\n"
+ "FIX TROSE LATLON N 37 41.949667 W 120 24.253333\n"
+ "FIX TRUKN LATLON N 37 43.0535 W 122 12.875333\n"
+ "FIX TYDYE LATLON N 37 41.359166 W 122 16.136666\n"
+ "FIX UPEND LATLON N 38 1.919 W 122 5.824\n"
+ "FIX URRSA LATLON N 37 36.186667 W 122 20.2705\n"
+ "FIX UTOOB LATLON N 37 24.695833 W 122 20.333\n"
+ "FIX VIKYU LATLON N 37 42.810667 W 122 35.772334\n"
+ "FIX WAMMY LATLON N 37 32.463833 W 122 43.443334\n"
+ "FIX WASOP LATLON N 37 31.810667 W 122 7.291\n"
+ "FIX WESLA LATLON N 37 39.862333 W 122 28.8175\n"
+ "FIX WETOR LATLON N 37 29.083166 W 122 3.4285\n"
+ "FIX WIBNI LATLON N 37 31.003166 W 122 1.881833\n"
+ "FIX WPOUT LATLON N 37 7.169167 W 122 17.5645\n"
+ "FIX WUSES LATLON N 37 39.347833 W 124 0.098\n"
+ "FIX WWAVS LATLON N 36 44.491834 W 121 53.654\n"
+ "FIX XATTU LATLON N 37 40.271333 W 122 29.689667\n"
+ "FIX YOSEM LATLON N 37 45.7645 W 118 45.996667\n"
+ "FIX YYUNG LATLON N 35 30.965 W 121 4.121167\n"
+ "FIX ZILED LATLON N 37 29.7375 W 121 57.492667\n"
+ "FIX ZOMER LATLON N 37 32.720833 W 120 37.8865\n"
+ "ENDFIXES";

            Assert.Equal(expectedValue, airport.ParseFixes());
        }

        [Fact]
        public void TestFixParserForIKA()
        {
            Airport airport = new Airport();
            airport.Fixes.Add("AF001", new Fix("AF001", new GeoLocation("N 35 16.529306 E 51 19.897601", GeoStringFormat.DD)));
            airport.Fixes.Add("AF002", new Fix("AF002", new GeoLocation("N 35 17.649938 E 51 21.182042", GeoStringFormat.DD)));
            airport.Fixes.Add("BOXAM", new Fix("BOXAM", new GeoLocation("N 34 37.816667 E 51 51.783334", GeoStringFormat.DD)));
            airport.Fixes.Add("CD11L", new Fix("CD11L", new GeoLocation("N 35 29.017667 E 50 55.749667", GeoStringFormat.DD)));
            airport.Fixes.Add("CD11R", new Fix("CD11R", new GeoLocation("N 35 28.803334 E 50 55.657667", GeoStringFormat.DD)));
            airport.Fixes.Add("CD29R", new Fix("CD29R", new GeoLocation("N 35 21.145333 E 51 22.196167", GeoStringFormat.DD)));
            airport.Fixes.Add("CF29R", new Fix("CF29R", new GeoLocation("N 35 21.014 E 51 23.4375", GeoStringFormat.DD)));
            airport.Fixes.Add("D116K", new Fix("D116K", new GeoLocation("N 35 18.8965 E 51 22.229833", GeoStringFormat.DD)));
            airport.Fixes.Add("D140J", new Fix("D140J", new GeoLocation("N 35 16.372166 E 51 17.7135", GeoStringFormat.DD)));
            airport.Fixes.Add("D140K", new Fix("D140K", new GeoLocation("N 35 15.551 E 51 18.412667", GeoStringFormat.DD)));
            airport.Fixes.Add("D140O", new Fix("D140O", new GeoLocation("N 35 12.265667 E 51 21.207334", GeoStringFormat.DD)));
            airport.Fixes.Add("DAXIL", new Fix("DAXIL", new GeoLocation("N 34 51.583333 E 49 34.9", GeoStringFormat.DD)));
            airport.Fixes.Add("DHN", new Fix("DHN", new GeoLocation("N 35 15.25 E 52 43.2", GeoStringFormat.DD)));
            airport.Fixes.Add("EGVEL", new Fix("EGVEL", new GeoLocation("N 34 42.966667 E 50 30.083333", GeoStringFormat.DD)));
            airport.Fixes.Add("FD11L", new Fix("FD11L", new GeoLocation("N 35 27.3145 E 51 1.506167", GeoStringFormat.DD)));
            airport.Fixes.Add("FD11R", new Fix("FD11R", new GeoLocation("N 35 27.182666 E 51 1.449334", GeoStringFormat.DD)));
            airport.Fixes.Add("FD29R", new Fix("FD29R", new GeoLocation("N 35 22.864834 E 51 16.454333", GeoStringFormat.DD)));
            airport.Fixes.Add("FF29R", new Fix("FF29R", new GeoLocation("N 35 22.835 E 51 16.948166", GeoStringFormat.DD)));
            airport.Fixes.Add("IE402", new Fix("IE402", new GeoLocation("N 35 21.549 E 51 21.534833", GeoStringFormat.DD)));
            airport.Fixes.Add("IE403", new Fix("IE403", new GeoLocation("N 35 23.171167 E 51 15.748", GeoStringFormat.DD)));
            airport.Fixes.Add("IE404", new Fix("IE404", new GeoLocation("N 35 25.520333 E 51 7.331833", GeoStringFormat.DD)));
            airport.Fixes.Add("IE405", new Fix("IE405", new GeoLocation("N 35 17.0475 E 51 4.618667", GeoStringFormat.DD)));
            airport.Fixes.Add("IE410", new Fix("IE410", new GeoLocation("N 36 8.567 E 50 26.681833", GeoStringFormat.DD)));
            airport.Fixes.Add("IKA", new Fix("IKA", new GeoLocation("N 35 24.58 E 51 10.708333", GeoStringFormat.DD)));
            airport.Fixes.Add("ITKOB", new Fix("ITKOB", new GeoLocation("N 35 21.1105 E 51 27.6265", GeoStringFormat.DD)));
            airport.Fixes.Add("KAZNB", new Fix("KAZNB", new GeoLocation("N 35 31.001666 E 51 22.011667", GeoStringFormat.DD)));
            airport.Fixes.Add("MD29R", new Fix("MD29R", new GeoLocation("N 35 24.408667 E 51 11.283", GeoStringFormat.DD)));
            airport.Fixes.Add("MIVAK", new Fix("MIVAK", new GeoLocation("N 35 59.25 E 49 53.4", GeoStringFormat.DD)));
            airport.Fixes.Add("MUXOR", new Fix("MUXOR", new GeoLocation("N 35 29.5 E 52 41.783333", GeoStringFormat.DD)));
            airport.Fixes.Add("NABAX", new Fix("NABAX", new GeoLocation("N 36 9.916667 E 50 48.266666", GeoStringFormat.DD)));
            airport.Fixes.Add("NAGMO", new Fix("NAGMO", new GeoLocation("N 36 2.233333 E 51 20.916667", GeoStringFormat.DD)));
            airport.Fixes.Add("OBRIX", new Fix("OBRIX", new GeoLocation("N 34 45.666667 E 52 8.666666", GeoStringFormat.DD)));
            airport.Fixes.Add("OXAVA", new Fix("OXAVA", new GeoLocation("N 35 17.048833 E 51 24.221", GeoStringFormat.DD)));
            airport.Fixes.Add("PAROT", new Fix("PAROT", new GeoLocation("N 36 11.466667 E 49 58.683334", GeoStringFormat.DD)));
            airport.Fixes.Add("PAVET", new Fix("PAVET", new GeoLocation("N 35 26.65 E 49 53.016667", GeoStringFormat.DD)));
            airport.Fixes.Add("PAXID", new Fix("PAXID", new GeoLocation("N 36 17.05 E 50 20.35", GeoStringFormat.DD)));
            airport.Fixes.Add("RADAL", new Fix("RADAL", new GeoLocation("N 34 54.383333 E 52 20.383333", GeoStringFormat.DD)));
            airport.Fixes.Add("RUS", new Fix("RUS", new GeoLocation("N 35 26.728333 E 50 54.321667", GeoStringFormat.DD)));
            airport.Fixes.Add("RW29R", new Fix("RW29R", new GeoLocation("N 35 24.788833 E 51 9.957167", GeoStringFormat.DD)));
            airport.Fixes.Add("SAVNB", new Fix("SAVNB", new GeoLocation("N 35 1.113334 E 50 22.281667", GeoStringFormat.DD)));
            airport.Fixes.Add("TRN", new Fix("TRN", new GeoLocation("N 35 41.818333 E 51 17.026667", GeoStringFormat.DD)));
            airport.Fixes.Add("TRN28", new Fix("TRN28", new GeoLocation("N 35 44.190167 E 50 42.627", GeoStringFormat.DD)));
            airport.Fixes.Add("TRN40", new Fix("TRN40", new GeoLocation("N 35 5.300167 E 51 37.133333", GeoStringFormat.DD)));
            airport.Fixes.Add("VRNB", new Fix("VRNB", new GeoLocation("N 35 20.56 E 51 38.23", GeoStringFormat.DD)));

            string expectedValue = "FIXES\n"
                + "FIX AF001 LATLON N 35 16.529306 E 51 19.897601\n"
                + "FIX AF002 LATLON N 35 17.649938 E 51 21.182042\n"
                + "FIX BOXAM LATLON N 34 37.816667 E 51 51.783334\n"
                + "FIX CD11L LATLON N 35 29.017667 E 50 55.749667\n"
                + "FIX CD11R LATLON N 35 28.803334 E 50 55.657667\n"
                + "FIX CD29R LATLON N 35 21.145333 E 51 22.196167\n"
                + "FIX CF29R LATLON N 35 21.014 E 51 23.4375\n"
                + "FIX D116K LATLON N 35 18.8965 E 51 22.229833\n"
                + "FIX D140J LATLON N 35 16.372166 E 51 17.7135\n"
                + "FIX D140K LATLON N 35 15.551 E 51 18.412667\n"
                + "FIX D140O LATLON N 35 12.265667 E 51 21.207334\n"
                + "FIX DAXIL LATLON N 34 51.583333 E 49 34.9\n"
                + "FIX DHN LATLON N 35 15.25 E 52 43.2\n"
                + "FIX EGVEL LATLON N 34 42.966667 E 50 30.083333\n"
                + "FIX FD11L LATLON N 35 27.3145 E 51 1.506167\n"
                + "FIX FD11R LATLON N 35 27.182666 E 51 1.449334\n"
                + "FIX FD29R LATLON N 35 22.864834 E 51 16.454333\n"
                + "FIX FF29R LATLON N 35 22.835 E 51 16.948166\n"
                + "FIX IE402 LATLON N 35 21.549 E 51 21.534833\n"
                + "FIX IE403 LATLON N 35 23.171167 E 51 15.748\n"
                + "FIX IE404 LATLON N 35 25.520333 E 51 7.331833\n"
                + "FIX IE405 LATLON N 35 17.0475 E 51 4.618667\n"
                + "FIX IE410 LATLON N 36 8.567 E 50 26.681833\n"
                + "FIX IKA LATLON N 35 24.58 E 51 10.708333\n"
                + "FIX ITKOB LATLON N 35 21.1105 E 51 27.6265\n"
                + "FIX KAZNB LATLON N 35 31.001666 E 51 22.011667\n"
                + "FIX MD29R LATLON N 35 24.408667 E 51 11.283\n"
                + "FIX MIVAK LATLON N 35 59.25 E 49 53.4\n"
                + "FIX MUXOR LATLON N 35 29.5 E 52 41.783333\n"
                + "FIX NABAX LATLON N 36 9.916667 E 50 48.266666\n"
                + "FIX NAGMO LATLON N 36 2.233333 E 51 20.916667\n"
                + "FIX OBRIX LATLON N 34 45.666667 E 52 8.666666\n"
                + "FIX OXAVA LATLON N 35 17.048833 E 51 24.221\n"
                + "FIX PAROT LATLON N 36 11.466667 E 49 58.683334\n"
                + "FIX PAVET LATLON N 35 26.65 E 49 53.016667\n"
                + "FIX PAXID LATLON N 36 17.05 E 50 20.35\n"
                + "FIX RADAL LATLON N 34 54.383333 E 52 20.383333\n"
                + "FIX RUS LATLON N 35 26.728333 E 50 54.321667\n"
                + "FIX RW29R LATLON N 35 24.788833 E 51 9.957167\n"
                + "FIX SAVNB LATLON N 35 1.113334 E 50 22.281667\n"
                + "FIX TRN LATLON N 35 41.818333 E 51 17.026667\n"
                + "FIX TRN28 LATLON N 35 44.190167 E 50 42.627\n"
                + "FIX TRN40 LATLON N 35 5.300167 E 51 37.133333\n"
                + "FIX VRNB LATLON N 35 20.56 E 51 38.23\n"
                + "ENDFIXES";

            Assert.Equal(expectedValue, airport.ParseFixes());
        }
    }
}
