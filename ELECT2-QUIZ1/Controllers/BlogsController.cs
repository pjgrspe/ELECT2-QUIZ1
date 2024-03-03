using ELECT2_QUIZ1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ELECT2_QUIZ1.Controllers
{
    public class BlogsController : Controller
    {
        public IActionResult Index(int year, int month, string slug)
        {
            var blogPost = new List<BlogsModel>
            {
                new BlogsModel
                {
                    Id = 1,
                    Title = "Four 'One Piece'-Themed PUMA Suede Sneakers Are Coming",
                    Content = "One Piece mania is alive and well. The beloved manga and its anime adaptation have been enjoyed by fans across the world for decades, and with Netflix’s hit live-action rendition, alongside news of an anime remake, the franchise continues to grow in popularity.\n\nNow, PUMA is reigniting its partnership with One Piece by offering its Suede sneaker in four different character-themed looks that have been previewed by the brand. First, Luffy’s Gear 5 form comes to life with a cloudy-white rendition that carries references to the pirate with elements like its hair-inspired Formstrip. Blackbeard and Shanks have also received their own looks, with the former favoring a black and gold that draws from his captain’s coat and the latter utilizing Shanks’ three iconic scars at the lateral heel. The Buggy colorway ties the collection together with a red and blue combination that nods to the clown pirate’s instantly-recognizable look.\n\nFor those looking forward to picking up a pair of the latest One Piece x PUMA sneakers, all four of these Suede colorways are scheduled to launch on March 23 at a price of $85 USD via PUMA and select retailers worldwide. Stay tuned for a complete visual breakdown of each, as well as a look at the accompanying apparel range.",
                    MainImage = "img/BLOG-1.png",
                    Writer = "Logan Fairbrother",
                    Year = 2024,
                    Month = 2,
                    Slug = "one-piece-puma-suede-sneakers"
                },
                new BlogsModel
                {
                    Id = 2,
                    Title = "Ye and Ty Dolla $ign Officially Release Collab Album 'Vultures, Volume 1'",
                    Content = "¥$, the duo of Ty Dolla $ign and Ye, have officially released the first volume of their long-awaited collaborative album Vultures.\n\nClocking in at 55 minutes, the 18-track album features the previously-released title track with Bump J and Lil Durk and “Talking / Once Again” featuring your bestie, Ms. North West(ie). Also joining Volume 1 are Charlie Wilson, Freddie Gibbs, Quavo, Playboi Carti, Travis Scott, Chris Brown, YG, Future Timbaland, James Blake, Young Thug, Leon Bridges and Kid Cudi.\n\nThe record was initially teased in October but was delayed as the pair shopped the album for a distributor. The pair had planned a multi-stadium listening party in early November that was eventually canceled , followed by successful raves in Miami and Las Vegas. Ye and Ty also celebrated the release of the project with a global livestream listening experience from the United Center in Chicago, where they brought out Freddie Gibbs, YG and North West.\n\nStream Ty Dolla $ign and Kanye West’s Vultures, Volume 1 on Spotify and Apple Music.",
                    MainImage = "img/BLOG-2.png",
                    Writer = "Sophie Caraan",
                    Year = 2024,
                    Month = 2,
                    Slug = "ye-and-ty-dolla-album"
                },
                new BlogsModel
                {
                    Id = 3,
                    Title = "Buzz and Woody Come to Life on the Crocs Classic Clog",
                    Content = "Last week, Crocs flipped a switch and a myriad of collaborations have gone viral in the sneaker space. Utilizing the Classic Clog, fan-favorite franchises such as Naruto and SpongeBob SquarePants have seen their main characters outfit the popular slip-on silhouette. From there, UK streetwear heavyweight Palace included the Classic Clog in its presentation of its spring collection.\n\nNow, it’s time for Pixar’s beloved Toy Story series to have two of its characters receive their own colorway of the clog. Buzz Lightyear is the subject of the first look, with his Pulsar-400 Enviro-Suit serving as the key point of inspiration — informing the green and white color arrangement of the clog while its purple appears at the strap. Thematic graphics appear via the Jibbitz, as well as at the midsole, midfoot and the right shoe’s footbed. As for its accompanying look, Sheriff Woody sees his vest’s cow print served up at the forefoot, while the rest of his usual ensemble is spread throughout the slip-on, including a rich brown that draws from his boots at the strap. Special Jibbitz for the pair range from a cowboy hat to his sheriff star.\n\nAt the time of writing, we’re awaiting word from Crocs regarding the launch details of its Toy Story-themed Classic Clogs. The brand has yet to announce both this project and its other upcoming media-based collaborations so stay tuned as they are all likely to be revealed in the coming months.",
                    MainImage = "img/BLOG-3.png",
                    Writer = "Logan Fairbrother",
                    Year = 2024,
                    Month = 1,
                    Slug = "buzz-and-woody-crocs"
                },
                new BlogsModel
                {
                    Id = 4,
                    Title = "Pharrell's Louis Vuitton FW24 Collection Is a LVERS' Vision of the American Western Wardrobe",
                    Content = "Coming off of his Pre-Fall 2024 show in Hong Kong, worthy of a spectacle, Pharrell Williams is back with another show-stopping presentation of his latest collection. Kicking off as the first official show of Paris Fashion Week for the Fall/Winter 2024 season, Pharrell takes audiences to the Fondation Louis Vuitton to present his third show for the house.\n\nContinuing the theme of LVERS — a bridge between Virgina and Paris — Pharrell continues to push the bar higher. One cannot forget Pharrell’s debut show which brought pop culture royalty to attend and later, his Hong Kong show which saw the memorable skyline as the backdrop and a drone show to cap it off. Prior to the show, Pharrell teased the collection on his Skateboard Instagram page various cowboy Western motifs. From cowboy hats with the signature LVERS moniker to monogrammed Timbaland boots, Pharrell appears to bring American and hip-hop staples into high-fashion. The show invite was accompanied by a harmonica, a key accessory often associated with the popular image of the cowboy.\n\nCountry and Western motifs carried onto the runway as Pharrell dives deeper into the roots of the American Western wardrobe. With travel at the center of the house’s core, the exploration of the origins of workwear take center stage as it is transformed into the savoir-fair of Louis Vuitton. Through craftsmanship and embroidery techniques, the collection highlights key iconography of American Western dress. Pharrell honoring the workwear intrinsic to the American Western wardrobe by amplifying tropes from denim to blanket coats to Buffalo Check and chaps that are rooted in the cowboy aesthetic. The Louis Vuitton style evolves with the American Western dandy, featuring cowboy shirts, workwear silhouettes that feature beading and ornamentation.\n\nHoning in on the American Western theme, the collection collaborated with artist from the Dakota and Lakota nations across accessories and even the show’s staging and soundtrack. It was headed by creative director Dee Jay Two Bears of the Standing Rock Sioux Tribe. The artists also collaborated on a Speedy bag, messenger bag and travel tote, embroidered with Dakota Flower symbolism. Staying true to the American workwear aesthetic, the Timberland collaboration saw iconic work boots interpreted through the creative lens of Louis Vuitton. From cowboy hats to leather caps and gloves ornamented with buckles and gems that embody the prairie dandy, the collection presentation was complemented with performers from the Native Voices of Resistance. Of course, Pharrell had his hand in the unique soundtrack which saw original pieces like “The Spirit of Saturday Night Live by the Native Voices of Resistance x Pharrell Williams, “Good People” by Mumford & Suns and Pharrell as well as “Shotgun Wedding” by Pharrell and Jelly Roll and “Doctor” by Pharrell and Miley Cyrus.",
                    MainImage = "img/BLOG-4.png",
                    Writer = "Joyce Li",
                    Year = 2024,
                    Month = 1,
                    Slug = "pharell-lv-fw24-collection"
                },
                new BlogsModel
                {
                    Id = 5,
                    Title = "Official Images of the ‘Naruto’ x ASICS GEL-NYC",
                    Content = "Since the creation of Naruto in 1999, it has been one of the most popular Japanese manga and anime television adventure series in contemporary culture. Although the Japanese manga has ended, the anime television series continues to see new iterations. But what also continues its legacy is its weaving in popular culture, which has touched the likes of apparel, collaborations and more. Well, now a new collaboration has surfaced as Naruto has merged with ASICS’ popular GEL-NYC silhouette.\n\nThis isn’t the first time the two entities have teamed up – offering up the ASICS Naruto Shippuden x Gel Lyte 3 OG “Kakashi.” Now taking the signature GEL-NYC shoe, the new shoe’s theme is inspired by Naruto’s Sage Mode. With it, the sneaker features a lace lock with Naruto’s scroll, a scratch nodding to Western imagery, a dubrae with the Leaf Village logo and Naruto Uzumaki’s logo on the tongue.\n\nThe sneakers appear largely in black but are highlighted by accents of Naruto’s signature orange shade and fuschia. Finishing off the shoes is the ASICS side logo in white and a special edition box.",
                    MainImage = "img/BLOG-5.png",
                    Writer = "Brycen Saunders and Logan Fairbrother",
                    Year = 2024,
                    Month = 1,
                    Slug = "naruto-x-asics-gel-nyc"
                },
                new BlogsModel
                {
                    Id = 6,
                    Title = "Manny Pacquiao Officially Announces Rematch Against Floyd Mayweather",
                    Content = "Manny Pacquiao vs. Floyd Mayweather 2 is officially in the cards.\n\nThe announcement was made by the Filipino boxer and RIZIN Fighting Federation head Nobuyiki Sakakibara at a New Year’s Eve event at the Saitama Super Arena in Japan. Pacquiao first apologized to the crowd as he was not involved in any bouts in 2023 after signing a contract with RIZIN, then confirmed that the “big fight” against Mayweather will take place in Japan in 2024. “I’m excited for that. Thank you,” he said, and did not reveal any additional details.\n\nAs per Bloody Elbow, the rematch of their 2015 bout will most likely be an exhibition and not a professional match. Both boxers have already professionally retired, and have only gone back in the ring for exhibition matches ever since.\n\nTheir 2015 fight is the best-selling pay-per-view bout in history with approximately 4.6 million buys, and saw Mayweather win via unanimous decision at the MGM Grand Garden Arena in Las Vegas.",
                    MainImage = "img/BLOG-6.png",
                    Writer = "Sophie Caraan",
                    Year = 2024,
                    Month = 2,
                    Slug = "manny-vs-floyd-announcement"
                },
            };

            var matchingPost = blogPost
                            .Where(post => post.Year == year &&
                                           post.Month == month &&
                                           post.Slug == slug)
                            .FirstOrDefault();
            if (matchingPost == null)
            {
                return NotFound();
            }

            return View(matchingPost);
        }
    }
}
