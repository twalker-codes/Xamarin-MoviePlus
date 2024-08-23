using System;
using System.Collections.Generic;
using MovieStreamTemplate.Models;

namespace MovieStreamTemplate.DataStores.MockDataStore
{
    public class ReviewDataStore: BaseDataStore<Review>, IReviewDataStore
    {
        protected override IList<Review> items { get; }

        public ReviewDataStore()
        {
            items = new List<Review>
            {
                new Review
                {
                    Id = "001",
                    MovieId = "001",
                    PersonId = "013",
                    Star = 5,
                    DateGmt = new DateTime(2021, 1,3),
                    Text = "Etiam molestie dictum ipsum vel vehicula. Ut egestas diam odio, eget maximus mi rutrum quis. Nulla ac elementum mauris, non placerat nisi. In fermentum metus eu nisl pulvinar, ut vestibulum tortor mollis."
                },

                new Review
                {
                    Id = "002",
                    MovieId = "016",
                    PersonId = "026",
                    Star = 4,
                    DateGmt = new DateTime(2021, 1, 3),
                    Text = "Vivamus sodales nisi vel justo aliquet sollicitudin. Proin at condimentum eros, sed faucibus neque. Donec maximus augue elit, sed accumsan nisl consequat at. Donec ut convallis risus. Fusce viverra ipsum quis eleifend dignissim. Praesent eu vestibulum dolor. Phasellus ultrices malesuada ante, eu scelerisque neque volutpat eget. Curabitur tempus tellus at orci maximus egestas. In imperdiet euismod congue."
                },

                new Review
                {
                    Id = "003",
                    MovieId = "050",
                    PersonId = "035",
                    Star = 5,
                    DateGmt = new DateTime(2021, 1, 5),
                    Text = "Quisque ultrices sem vitae aliquam pellentesque. Morbi ut mi eu nisl venenatis placerat sit amet at odio. Proin eu eros sapien. Maecenas est tellus, ultricies quis libero et, aliquam posuere urna. Integer rutrum tortor a pellentesque sodales."
                },

                new Review
                {
                    Id = "004",
                    MovieId = "002",
                    PersonId = "001",
                    Star = 3,
                    DateGmt = new DateTime(2021, 1, 18),
                    Text = "Suspendisse eget nibh quis elit mollis viverra a a leo. Vestibulum sed lorem et ipsum lobortis ullamcorper."
                },

                new Review
                {
                    Id = "005",
                    MovieId = "044",
                    PersonId = "009",
                    Star = 2,
                    DateGmt = new DateTime(2021, 1, 21),
                    Text = "Integer laoreet dolor quis magna hendrerit aliquam. Mauris sit amet rutrum ipsum. Nulla ultrices facilisis nisi et interdum. Donec eu aliquet libero, eget blandit magna. Integer facilisis risus leo, sed porta ex ornare eu."
                },

                new Review
                {
                    Id = "006",
                    MovieId = "032",
                    PersonId = "012",
                    Star = 4,
                    DateGmt = new DateTime(2021, 1, 22),
                    Text = "Phasellus pretium varius aliquam. In semper ipsum eget ex porta, vel hendrerit urna aliquam. Aliquam arcu ante, vestibulum ac egestas sed, semper dignissim urna. Morbi eu nunc malesuada, ultrices orci non, auctor magna. Ut sit amet libero tempor, eleifend dui a, imperdiet massa."
                },

                new Review
                {
                    Id = "007",
                    MovieId = "011",
                    PersonId = "026",
                    Star = 3,
                    DateGmt = new DateTime(2021, 1, 22),
                    Text = "Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Etiam vitae mauris consequat, semper turpis quis, fringilla ligula. Cras in nunc dapibus tellus cursus finibus a a dolor. Sed hendrerit fringilla tellus, ut dignissim ipsum iaculis nec. Phasellus fermentum magna sapien, quis varius felis viverra vitae. Proin cursus tortor purus, a vehicula erat luctus viverra. Nunc diam turpis, tempus id lobortis at, tempus non ante. Sed eget massa iaculis, accumsan lorem vehicula, placerat metus. Morbi congue orci volutpat nisl rutrum efficitur. Fusce volutpat tortor tortor, ac mattis arcu laoreet nec. Morbi tortor felis, luctus at ipsum ac, rhoncus elementum erat. Maecenas egestas fermentum lorem at varius."
                },

                new Review
                {
                    Id = "008",
                    MovieId = "022",
                    PersonId = "043",
                    Star = 4,
                    DateGmt = new DateTime(2021, 1, 25),
                    Text = "Aliquam vitae feugiat libero. Mauris semper ipsum arcu, sit amet auctor tellus hendrerit vitae. Fusce auctor vel lorem id eleifend. Nunc mollis sem sit amet velit convallis dignissim. Sed non nibh malesuada, dapibus nulla quis, egestas lectus. Aenean sit amet vulputate justo, efficitur tristique tortor."
                },

                new Review
                {
                    Id = "009",
                    MovieId = "056",
                    PersonId = "009",
                    Star = 5,
                    DateGmt = new DateTime(2021, 2, 3),
                    Text = "Morbi venenatis sem nec est facilisis consequat."
                },

                new Review
                {
                    Id = "010",
                    MovieId = "014",
                    PersonId = "060",
                    Star = 4,
                    DateGmt = new DateTime(2021, 2, 5),
                    Text = "Vivamus facilisis, sapien eu scelerisque pulvinar, justo neque convallis nunc, non auctor urna risus dictum sem. Duis eget luctus eros, vel iaculis magna. Donec vel sagittis dui. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Pellentesque lorem mi, egestas ac eleifend in, vulputate vitae tellus. Duis vehicula, diam ut euismod laoreet, neque odio luctus leo, a tempor velit neque non nisl. Sed dictum auctor erat, non congue elit lacinia nec. Fusce ac libero eu leo pharetra rhoncus. Etiam vitae sem in magna feugiat eleifend. Quisque tincidunt consequat nulla, sed eleifend nunc hendrerit at. Vestibulum dictum velit eget ligula vehicula eleifend. Praesent et nibh porttitor metus blandit malesuada in sed nulla. Donec mollis vel urna a feugiat."
                },

                new Review
                {
                    Id = "011",
                    MovieId = "050",
                    PersonId = "031",
                    Star = 3,
                    DateGmt = new DateTime(2021, 2, 8),
                    Text = "Duis libero orci, varius in nibh sed, scelerisque imperdiet turpis. In congue ultricies libero, sit amet scelerisque libero ullamcorper sit amet. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Interdum et malesuada fames ac ante ipsum primis in faucibus. Proin suscipit velit ac egestas efficitur. Etiam semper sagittis lobortis."
                },

                new Review
                {
                    Id = "012", MovieId = "030", PersonId = "047", Star = 1,
                    DateGmt = new DateTime(2021, 2, 11),
                    Text = "Nam ornare est massa, ac pharetra mi ullamcorper non. Praesent molestie est massa, et placerat risus congue id. Sed dignissim congue nisl, vitae euismod purus convallis malesuada. Vivamus ornare sollicitudin ipsum, ac aliquam nibh sagittis id. Fusce volutpat, arcu nec gravida fermentum, velit tellus laoreet est, sit amet tristique elit velit ut odio. Pellentesque cursus leo ligula, ac egestas magna semper at."
                },

                new Review
                {
                    Id = "013",
                    MovieId = "033",
                    PersonId = "052",
                    Star = 5,
                    DateGmt = new DateTime(2021, 2, 13),
                    Text = "Nunc eget sollicitudin velit, ut porta leo. In lobortis sit amet quam in iaculis. Donec non egestas orci. Suspendisse nec risus sit amet purus venenatis lacinia. Curabitur vehicula quam at nisi dapibus tempus. Nam eu justo eu nulla finibus vestibulum. Mauris eu est feugiat, tempus dolor sed, eleifend augue."
                },

                new Review
                {
                    Id = "014",
                    MovieId = "015",
                    PersonId = "010",
                    Star = 4,
                    DateGmt = new DateTime(2021, 2, 22),
                    Text = "Fusce porta diam sed lacinia pretium. Nulla finibus, ante sed dapibus hendrerit, ipsum eros gravida tellus, non faucibus nibh lacus vulputate est. Vivamus a volutpat velit. Phasellus quis mi non risus imperdiet gravida a vitae urna. Vivamus eu nibh sed sapien vestibulum feugiat ornare eu lorem. Sed vel odio quis purus dictum imperdiet ac at neque. Phasellus congue sit amet enim ut luctus. Suspendisse eget nisl quis est efficitur mollis. Nulla scelerisque nulla et gravida interdum. Cras laoreet tortor dolor, sed varius nisi gravida dictum. Quisque rhoncus nibh erat, id imperdiet felis sodales a. Praesent maximus auctor turpis, at hendrerit justo faucibus a. Curabitur vel tellus posuere, tristique justo vel, aliquet massa. Maecenas consequat eros purus, quis sodales mauris tristique ac."
                },

                new Review
                {
                    Id = "015",
                    MovieId = "038",
                    PersonId = "031",
                    Star = 2,
                    DateGmt = new DateTime(2021, 3, 1),
                    Text = "Duis et feugiat urna. Sed sit amet porttitor sem. Aenean eget pellentesque nibh, in imperdiet mauris. Mauris ut egestas lacus, fringilla scelerisque est. Duis quis elementum dui. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Praesent ac lectus vitae urna consequat tristique at porta tortor. Integer orci mauris, feugiat sit amet suscipit eget, interdum in dolor."
                },

                new Review
                {
                    Id = "016",
                    MovieId = "039",
                    PersonId = "027",
                    Star = 3,
                    DateGmt = new DateTime(2021, 3, 4),
                    Text = "Maecenas maximus aliquam orci, non vehicula leo posuere varius. Nullam lacus augue, dapibus malesuada euismod quis, placerat quis erat. Nunc feugiat placerat lacus sed blandit. Fusce vel augue ante. Sed hendrerit mauris sit amet arcu aliquet, ut pellentesque enim dictum. Nam eu nisl eget tellus fringilla faucibus. Pellentesque in mi ipsum. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam nec cursus mi. Donec non libero ac nulla euismod tempus ac sed purus. Nunc eget cursus tortor. Aenean ullamcorper elit sed felis eleifend, eget vulputate urna sodales. Donec eu neque et turpis elementum placerat. Donec pulvinar consectetur odio sit amet gravida."
                },

                new Review
                {
                    Id = "017",
                    MovieId = "003",
                    PersonId = "055",
                    Star = 3,
                    DateGmt = new DateTime(2021, 3, 9),
                    Text = "Donec varius enim sagittis tortor egestas scelerisque. Nulla pulvinar est in ligula pretium pharetra. Sed luctus convallis mi in efficitur. Duis a mi feugiat, tristique urna in, tincidunt orci. Donec mi lorem, tempor nec imperdiet tempus, faucibus et est. Curabitur quis aliquet libero. Nulla efficitur laoreet tortor quis pharetra. Vestibulum faucibus nisl tempus, ultrices felis sodales, pharetra neque. Mauris tempus bibendum mi, a malesuada nisi pretium vel."
                },

                new Review
                {
                    Id = "018",
                    MovieId = "049",
                    PersonId = "004",
                    Star = 4,
                    DateGmt = new DateTime(2021, 3, 12),
                    Text = "Suspendisse sollicitudin, velit vitae dignissim hendrerit, dui ante viverra tellus, in porta arcu velit at tortor. Sed quis elit ac urna mattis luctus. Sed ante arcu, pulvinar id enim semper, molestie varius ipsum. Cras at dolor non nisl commodo fringilla id ac magna."
                },

                new Review
                {
                    Id = "019",
                    MovieId = "041",
                    PersonId = "017",
                    Star = 2,
                    DateGmt = new DateTime(2021, 3, 15),
                    Text = "Curabitur vehicula libero mi, eget iaculis nibh elementum non. Nunc maximus metus elementum neque maximus, non viverra sapien venenatis."
                },

                new Review
                {
                    Id = "020",
                    MovieId = "040",
                    PersonId = "026",
                    Star = 4,
                    DateGmt = new DateTime(2021, 3, 22),
                    Text = "Pellentesque quis quam urna. Morbi vel sem ut turpis vehicula elementum ac ac turpis. Suspendisse venenatis, arcu eu fringilla consectetur, metus ipsum pulvinar magna, in tincidunt dolor erat a nisi. Ut blandit lorem efficitur est lobortis, eu egestas purus pellentesque. Quisque faucibus vitae libero eget maximus."
                },

                new Review
                {
                    Id = "021",
                    MovieId = "042",
                    PersonId = "032",
                    Star = 3,
                    DateGmt = new DateTime(2021, 3, 28),
                    Text = "Aliquam sit amet rutrum lacus."
                },

                new Review
                {
                    Id = "022",
                    MovieId = "044",
                    PersonId = "057",
                    Star = 5,
                    DateGmt = new DateTime(2021, 3, 30),
                    Text = "Aenean porttitor eleifend ipsum, sit amet sodales justo scelerisque et. Pellentesque vehicula sodales ex ac sodales. Donec volutpat felis ipsum, id blandit arcu laoreet ac. Phasellus id nibh cursus, lacinia ex ac, faucibus enim. Sed tincidunt urna egestas nulla dignissim tempor. Integer finibus pellentesque neque consequat aliquet. Nullam at laoreet nisl, vitae luctus dui. Mauris interdum nulla nibh, ut rhoncus sapien ultricies non. Nulla vitae tristique nibh. Aenean pulvinar, tellus sit amet cursus pretium, nisi odio tincidunt felis, vitae consectetur nibh erat ut eros."
                },

                new Review
                {
                    Id = "023",
                    MovieId = "048",
                    PersonId = "053", Star = 4,
                    DateGmt = new DateTime(2021, 3, 31),
                    Text = "Donec iaculis interdum erat non ullamcorper. Aliquam et suscipit nisl. Phasellus pulvinar, est eget viverra auctor, ipsum nulla tempus tortor, eget volutpat felis libero quis enim. Pellentesque in ipsum at nibh dictum aliquet. Sed molestie auctor arcu, a pretium dui aliquam vel. Fusce tincidunt suscipit condimentum. Duis ut commodo mi."
                },

                new Review
                {
                    Id = "024",
                    MovieId = "055",
                    PersonId = "049",
                    Star = 3,
                    DateGmt = new DateTime(2021, 4, 2),
                    Text = "Praesent id diam in justo varius maximus. Quisque at nulla nulla."
                },

                new Review
                {
                    Id = "025",
                    MovieId = "017",
                    PersonId = "030",
                    Star = 4,
                    DateGmt = new DateTime(2021, 4, 4),
                    Text = "Pellentesque in mi dolor. Ut et arcu eu diam tincidunt sollicitudin. Phasellus at diam euismod, tincidunt lacus eu, facilisis ex. Sed risus felis, pretium et dapibus a, euismod sed dui. Phasellus varius libero eget ultrices faucibus. Etiam suscipit feugiat ornare. Mauris eget elementum est, ac pellentesque urna. Aenean ultricies sagittis sem et dictum. Aenean sodales sed urna at ultricies. Nunc porttitor diam pulvinar massa molestie, in finibus nisi egestas. Sed in arcu a turpis volutpat pulvinar nec non felis."
                },

                new Review
                {
                    Id = "026",
                    MovieId = "047",
                    PersonId = "029",
                    Star = 2,
                    DateGmt = new DateTime(2021, 4, 6),
                    Text = "Vivamus dapibus ipsum at ultrices imperdiet. Donec elit mi, vulputate nec lacinia et, tempus ac mauris. Nunc massa nulla, eleifend a dui ut, sollicitudin scelerisque ipsum. Proin nisl neque, pellentesque nec tristique in, rutrum nec dolor. Integer eget velit ac leo pretium facilisis. Suspendisse potenti. Sed sem massa, suscipit ut risus tempus, convallis dapibus urna. Sed convallis metus sit amet fermentum sodales."
                },

                new Review
                {
                    Id = "027",
                    MovieId = "051",
                    PersonId = "054", Star = 5,
                    DateGmt = new DateTime(2021, 4, 8),
                    Text = "Nam lobortis mauris ut nunc suscipit, in blandit augue semper. Phasellus vehicula, urna a malesuada porta, ex orci gravida nunc, ac sodales turpis felis ut purus."
                },

                new Review
                {
                    Id = "028",
                    MovieId = "046",
                    PersonId = "060",
                    Star = 3,
                    DateGmt = new DateTime(2021, 4, 9),
                    Text = "Proin rhoncus justo vel ex finibus efficitur. Nam interdum urna eu malesuada faucibus. Integer molestie nisl ut tellus euismod, ut commodo est egestas. Vestibulum lobortis in sapien ac faucibus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur pulvinar euismod enim a eleifend. Proin ullamcorper risus id velit efficitur dictum."
                },

                new Review
                {
                    Id = "029",
                    MovieId = "053",
                    PersonId = "020",
                    Star = 1,
                    DateGmt = new DateTime(2021, 4, 13),
                    Text = "Quisque mattis elit a magna consequat, sed luctus felis ultricies. Proin malesuada nulla vitae lacus ullamcorper semper. Curabitur egestas turpis a congue facilisis. Aenean tincidunt ut nulla id hendrerit. Etiam non rutrum elit. Morbi vestibulum dictum sapien, sed pellentesque odio fermentum id. Vestibulum ac massa a tortor luctus vestibulum. Nam non tellus sit amet diam volutpat pulvinar sed quis lorem."
                },

                new Review
                {
                    Id = "030",
                    MovieId = "003",
                    PersonId = "018",
                    Star = 2,
                    DateGmt = new DateTime(2021, 4, 14),
                    Text = "Curabitur ac diam nec urna commodo efficitur nec sed sapien. Morbi quam mi, accumsan eget nisi a, pellentesque malesuada purus."
                },

                new Review
                {
                    Id = "031",
                    MovieId = "046",
                    PersonId = "034",
                    Star = 5,
                    DateGmt = new DateTime(2021, 4, 18),
                    Text = "Sed porta ultricies risus eu laoreet. Etiam convallis, enim in varius varius, felis tellus tincidunt neque, non ullamcorper nisi neque at mauris. Vivamus posuere laoreet lectus. Donec rutrum hendrerit vestibulum."
                },

                new Review
                {
                    Id = "032",
                    MovieId = "005",
                    PersonId = "029", Star = 4,
                    DateGmt = new DateTime(2021, 4, 20),
                    Text = "Proin pulvinar leo non orci eleifend cursus. Etiam ullamcorper, orci vel efficitur laoreet, lectus mi fermentum elit, et iaculis est nibh vel mi." },

                new Review
                {
                    Id = "033",
                    MovieId = "009",
                    PersonId = "012",
                    Star = 3,
                    DateGmt = new DateTime(2021, 5, 7),
                    Text = "Vivamus et suscipit sapien. Cras quis nisi luctus, tincidunt erat vitae, bibendum nunc."
                },

                new Review
                {
                    Id = "034",
                    MovieId = "030",
                    PersonId = "008",
                    Star = 2,
                    DateGmt = new DateTime(2021, 5, 11),
                    Text = "Mauris facilisis sapien vel justo vulputate, sed euismod nisl pharetra. Vivamus eget viverra massa. Nunc dignissim efficitur mi. Nunc dignissim suscipit iaculis. Suspendisse sit amet odio non eros ullamcorper tincidunt pretium id tellus. Quisque imperdiet ex sit amet sem scelerisque interdum."
                },

                new Review
                {
                    Id = "035",
                    MovieId = "045",
                    PersonId = "017",
                    Star = 3,
                    DateGmt = new DateTime(2021, 5, 16),
                    Text = "Curabitur sit amet justo placerat, condimentum metus ut, ullamcorper arcu. Duis gravida nunc lacus, in bibendum felis fermentum non. Integer luctus nibh a lorem rhoncus, id finibus odio tincidunt. Vivamus mi purus, sagittis in eleifend id, pharetra et mi. Sed non sollicitudin diam."
                },

                new Review
                {
                    Id = "036",
                    MovieId = "014",
                    PersonId = "008",
                    Star = 4,
                    DateGmt = new DateTime(2021, 5, 23),
                    Text = "Phasellus efficitur fringilla lorem, tincidunt hendrerit elit tempus vitae. Cras tortor ipsum, laoreet id vulputate a, pulvinar cursus ligula. Nunc sollicitudin tortor nunc, non lobortis nisi vulputate vel."
                },

                new Review
                {
                    Id = "037",
                    MovieId = "020",
                    PersonId = "023",
                    Star = 5,
                    DateGmt = new DateTime(2021, 5, 27),
                    Text = "Quisque sit amet libero in ipsum euismod rhoncus non a ex. Donec non pretium nibh. Donec vel arcu sed nisi sagittis porttitor ac quis metus. Aliquam a ante luctus, auctor turpis nec, hendrerit arcu. Morbi quis lectus nisl. Donec dapibus nisi at auctor blandit. Nullam aliquet elementum enim non volutpat. Maecenas ultrices sem sed justo dictum aliquet."
                },

                new Review
                {
                    Id = "038",
                    MovieId = "029",
                    PersonId = "017",
                    Star = 3,
                    DateGmt = new DateTime(2021, 5, 28),
                    Text = "Donec pharetra, felis at volutpat malesuada, sem ligula varius dui, eget porta erat sapien at erat. Integer malesuada nunc neque, porta commodo nulla commodo laoreet. In pharetra libero tellus, non venenatis libero vehicula nec. Donec vel nisl sapien. Aliquam erat volutpat."
                },

                new Review
                {
                    Id = "039",
                    MovieId = "030",
                    PersonId = "009",
                    Star = 2,
                    DateGmt = new DateTime(2021, 5, 28),
                    Text = "Cras porttitor arcu sit amet nisi feugiat, et fringilla leo varius. Quisque et sollicitudin augue. Etiam sit amet gravida magna, eget luctus neque. Nulla sed purus arcu. Morbi sapien tortor, gravida ut ullamcorper vitae, lacinia sit amet lectus. In hac habitasse platea dictumst."
                },

                new Review
                {
                    Id = "040",
                    MovieId = "031",
                    PersonId = "027",
                    Star = 3,
                    DateGmt = new DateTime(2021, 5, 29),
                    Text = "Etiam ultrices magna ligula, sed molestie quam faucibus sit amet."
                },

                new Review
                {
                    Id = "041",
                    MovieId = "022",
                    PersonId = "030",
                    Star = 2,
                    DateGmt = new DateTime(2021, 5, 31),
                    Text = "Vestibulum quis eleifend felis, non placerat lorem. Quisque nunc sapien, varius porttitor tortor vel, maximus convallis ante."
                },

                new Review
                {
                    Id = "042",
                    MovieId = "044",
                    PersonId = "054",
                    Star = 4,
                    DateGmt = new DateTime(2021, 5, 31),
                    Text = "Nunc ultrices in enim a consequat. Etiam fringilla orci ut leo scelerisque, pulvinar pellentesque arcu tristique. Vestibulum vulputate dapibus est, eget tincidunt diam aliquam a. Praesent viverra metus quis erat sagittis vehicula. Quisque neque orci, tempus eu lectus a, luctus feugiat felis."
                },

                new Review
                {
                    Id = "043",
                    MovieId = "028",
                    PersonId = "025",
                    Star = 5,
                    DateGmt = new DateTime(2021, 5, 31),
                    Text = "Nullam et risus at erat feugiat feugiat. Cras eu dignissim ante. Integer lacus sem, rhoncus sed neque quis, aliquet porta dui. Aenean consequat magna dolor, non vehicula dui posuere a."
                },

                new Review
                {
                    Id = "044",
                    MovieId = "007",
                    PersonId = "033",
                    Star = 3,
                    DateGmt = new DateTime(2021, 6, 2),
                    Text = "Integer libero ligula, auctor vel aliquet ut, scelerisque in enim. Sed aliquam vitae leo ut dapibus. Nullam in vehicula ex. Ut finibus metus purus, ut porta nibh finibus sodales. Vestibulum lacinia pharetra nulla sit amet sollicitudin. Pellentesque malesuada cursus ex rhoncus luctus. Donec interdum tincidunt lorem eget tristique. Donec lobortis rhoncus gravida. Praesent in massa nisi. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Duis eu dignissim purus. In auctor ante in nunc accumsan lobortis."
                },

                new Review
                {
                    Id = "045",
                    MovieId = "051",
                    PersonId = "042",
                    Star = 4,
                    DateGmt = new DateTime(2021, 6, 3),
                    Text = "Donec id leo vitae lorem vulputate maximus ac at mauris. Sed et pharetra nisl. Pellentesque ac maximus lorem. Quisque purus turpis, fringilla placerat lobortis et, elementum porta felis. Suspendisse faucibus vel ante id lobortis. Nunc congue nec est quis ultrices. Donec volutpat, mauris id mattis iaculis, nunc elit facilisis mauris, non viverra massa nisl at risus. Mauris sit amet urna lobortis, sollicitudin tellus ullamcorper, viverra sem."
                },

                new Review
                {
                    Id = "046",
                    MovieId = "013",
                    PersonId = "004",
                    Star = 3,
                    DateGmt = new DateTime(2021, 6, 6),
                    Text = "In ex erat, lobortis sed nisi ut, venenatis euismod nunc. In ipsum sapien, congue sed ipsum a, porttitor hendrerit metus. Sed cursus libero ipsum, et dictum ipsum consectetur sit amet. Curabitur vitae lectus lobortis, mollis elit ac, mollis felis. Nullam arcu felis, sollicitudin vel convallis sit amet, molestie pharetra risus. Maecenas viverra quam id convallis finibus. Nunc id mi quis augue posuere egestas at ac libero."
                },

                new Review
                {
                    Id = "047",
                    MovieId = "043",
                    PersonId = "041",
                    Star = 5,
                    DateGmt = new DateTime(2021, 6, 6),
                    Text = "Phasellus in convallis mauris, eget sollicitudin massa. Sed quis urna massa. Sed venenatis fermentum diam, sit amet elementum justo lobortis et."
                },

                new Review
                {
                    Id = "048",
                    MovieId = "019",
                    PersonId = "040",
                    Star = 2,
                    DateGmt = new DateTime(2021, 6, 8),
                    Text = "Fusce semper auctor libero. Praesent eget lorem sit amet urna maximus molestie. Ut eu odio et dui scelerisque posuere nec nec arcu. Nulla facilisi."
                },

                new Review
                {
                    Id = "049",
                    MovieId = "018",
                    PersonId = "013",
                    Star = 3,
                    DateGmt = new DateTime(2021, 6, 11),
                    Text = "Vivamus eu ipsum ut urna gravida tempor non eget ligula. Fusce vitae gravida ante, a blandit turpis. Nunc sodales, velit id semper luctus, erat ante ullamcorper diam, a molestie libero sapien non mi. Duis leo libero, congue id nibh ac, ornare vestibulum eros. In sem ipsum, tincidunt nec nisi sed, aliquet pharetra dui."
                },

                new Review
                {
                    Id = "050",
                    MovieId = "027",
                    PersonId = "019",
                    Star = 4,
                    DateGmt = new DateTime(2021, 6, 13),
                    Text = "Proin non tellus eu magna gravida dapibus eu ac odio. Suspendisse potenti. Aliquam commodo varius elit, volutpat venenatis lorem."
                },

                new Review
                {
                    Id = "051",
                    MovieId = "008",
                    PersonId = "026",
                    Star = 5,
                    DateGmt = new DateTime(2021, 6, 14),
                    Text = "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Maecenas bibendum neque sit amet eros ultricies, eget vehicula ex tincidunt. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; In lobortis, risus sit amet egestas laoreet, tellus tortor sollicitudin nibh, tempus vehicula augue tortor nec nulla."
                },

                new Review
                {
                    Id = "052",
                    MovieId = "020",
                    PersonId = "032",
                    Star = 4,
                    DateGmt = new DateTime(2021, 7, 16),
                    Text = "Nam dignissim at nunc placerat malesuada. Nullam et dolor nec justo dapibus cursus eu quis tellus. Ut vitae malesuada turpis. Duis id gravida justo, interdum elementum dui. Vivamus vel semper leo. Curabitur erat erat, ullamcorper non hendrerit eu, vestibulum a turpis."
                },

                new Review
                {
                    Id = "053",
                    MovieId = "009",
                    PersonId = "036",
                    Star = 4,
                    DateGmt = new DateTime(2021, 7, 20),
                    Text = "Quisque dignissim vel felis ac semper. Nam vel ligula massa. Fusce tincidunt odio vitae augue cursus, id placerat turpis bibendum. Curabitur mattis elit sem, id venenatis nibh sagittis ut. Maecenas in lobortis lectus. Duis malesuada quam at ipsum vulputate, quis iaculis nisi bibendum."
                },

                new Review
                {
                    Id = "054",
                    MovieId = "004",
                    PersonId = "050",
                    Star = 3,
                    DateGmt = new DateTime(2021, 7, 22),
                    Text = "Nunc in semper purus. Duis id turpis libero. Aenean rutrum fringilla felis, id ultrices felis. Sed aliquet ut purus eu luctus. Sed cursus luctus ante ut dignissim. Nullam vitae rutrum quam. Cras iaculis finibus nunc, sed faucibus erat elementum eget. Donec aliquam neque non orci porttitor, ac molestie ipsum finibus. Quisque tincidunt blandit varius. Fusce hendrerit, sapien a blandit sagittis, nunc nunc aliquet lectus, vel ultricies ligula lectus eu lacus."
                },

                new Review
                {
                    Id = "055",
                    MovieId = "002",
                    PersonId = "021",
                    Star = 5,
                    DateGmt = new DateTime(2021, 7, 23),
                    Text = "Phasellus dignissim tincidunt nunc at semper. Donec iaculis erat egestas, ultrices ante eu, ullamcorper lorem. Ut nulla neque, porttitor eu placerat eget, posuere non velit. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus sagittis felis dapibus erat accumsan luctus. Phasellus semper metus elit, ut malesuada lorem mollis ac. Praesent vestibulum orci a enim porta, vitae posuere felis vulputate. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aliquam in dui consectetur tellus hendrerit finibus id at neque. Nulla non luctus tellus, eu sollicitudin libero. Nam placerat metus ex. Pellentesque at ullamcorper dolor."
                },

                new Review
                {
                    Id = "056",
                    MovieId = "021",
                    PersonId = "019", Star = 4,
                    DateGmt = new DateTime(2021, 7, 24),
                    Text = "Curabitur at placerat ex, in pulvinar urna. Praesent accumsan diam et magna consequat rutrum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Vivamus et blandit felis, et scelerisque nulla. Nulla efficitur nibh at dui efficitur feugiat. Cras mi turpis, finibus nec convallis semper, laoreet id massa. Fusce ac nisi varius, pulvinar nisl condimentum, fermentum leo. Maecenas id purus id est consequat maximus eget convallis eros. Donec ut enim vel purus iaculis convallis vitae dictum quam. Nulla facilisis lectus at mi lacinia, nec molestie est dapibus. Mauris imperdiet libero dui, vel porta risus congue nec. Sed tempus elit metus, non pretium purus aliquet eu. Morbi eget ultrices nibh, sed ultrices purus."
                },

                new Review
                {
                    Id = "057",
                    MovieId = "006",
                    PersonId = "007",
                    Star = 3,
                    DateGmt = new DateTime(2021, 7, 25),
                    Text = "Integer tincidunt dolor at nibh dictum maximus. Curabitur at erat nisl. Donec id purus dignissim, vestibulum eros id, pharetra lacus. Pellentesque hendrerit, est vulputate pretium euismod, ex nisl rutrum mi, ut tempus elit nisi in mauris. Praesent at lorem non odio maximus iaculis."
                },

                new Review
                {
                    Id = "058",
                    MovieId = "012",
                    PersonId = "033",
                    Star = 2,
                    DateGmt = new DateTime(2021, 7, 28),
                    Text = "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; In euismod volutpat nibh, non faucibus dui luctus ac. Donec euismod dolor vitae pharetra mattis. Aliquam erat volutpat. Donec posuere nec arcu vel fringilla. In hac habitasse platea dictumst. Praesent dui sem, mollis at massa finibus, sollicitudin porta arcu. Sed eleifend turpis sed odio egestas, in blandit dolor maximus."
                },

                new Review
                {
                    Id = "059",
                    MovieId = "026",
                    PersonId = "042",
                    Star = 5,
                    DateGmt = new DateTime(2021, 7, 29),
                    Text = "Aenean auctor nibh gravida lorem iaculis, a sollicitudin nisl ullamcorper. Mauris aliquam velit vel tellus tincidunt, id elementum nulla mollis."
                },

                new Review
                {
                    Id = "060",
                    MovieId = "022",
                    PersonId = "011",
                    Star = 4,
                    DateGmt = new DateTime(2021, 7, 30),
                    Text = "Proin nulla ligula, fermentum vitae congue ac, rhoncus vel massa. Phasellus consectetur risus erat, at facilisis dolor imperdiet in. Duis ac ligula aliquam, pulvinar eros nec, gravida dolor. Pellentesque iaculis ex nisl, a consectetur eros feugiat mattis. Fusce facilisis sollicitudin nisl, condimentum mollis risus pulvinar vitae."
                },

                new Review
                {
                    Id = "061",
                    MovieId = "042",
                    PersonId = "032",
                    Star = 5,
                    DateGmt = new DateTime(2021, 7,31),
                    Text = "Etiam molestie dictum ipsum vel vehicula. Ut egestas diam odio, eget maximus mi rutrum quis. Nulla ac elementum mauris, non placerat nisi. In fermentum metus eu nisl pulvinar, ut vestibulum tortor mollis."
                },

                new Review
                {
                    Id = "062",
                    MovieId = "031",
                    PersonId = "019",
                    Star = 4,
                    DateGmt = new DateTime(2021, 7, 31),
                    Text = "Vivamus sodales nisi vel justo aliquet sollicitudin. Proin at condimentum eros, sed faucibus neque. Donec maximus augue elit, sed accumsan nisl consequat at. Donec ut convallis risus. Fusce viverra ipsum quis eleifend dignissim. Praesent eu vestibulum dolor. Phasellus ultrices malesuada ante, eu scelerisque neque volutpat eget. Curabitur tempus tellus at orci maximus egestas. In imperdiet euismod congue."
                },

                new Review
                {
                    Id = "063",
                    MovieId = "018",
                    PersonId = "037",
                    Star = 5,
                    DateGmt = new DateTime(2021, 8, 1),
                    Text = "Quisque ultrices sem vitae aliquam pellentesque. Morbi ut mi eu nisl venenatis placerat sit amet at odio. Proin eu eros sapien. Maecenas est tellus, ultricies quis libero et, aliquam posuere urna. Integer rutrum tortor a pellentesque sodales."
                },

                new Review
                {
                    Id = "064",
                    MovieId = "019",
                    PersonId = "028",
                    Star = 3,
                    DateGmt = new DateTime(2021, 8, 3),
                    Text = "Suspendisse eget nibh quis elit mollis viverra a a leo. Vestibulum sed lorem et ipsum lobortis ullamcorper."
                },

                new Review
                {
                    Id = "065",
                    MovieId = "022",
                    PersonId = "041",
                    Star = 2,
                    DateGmt = new DateTime(2021, 8, 6),
                    Text = "Integer laoreet dolor quis magna hendrerit aliquam. Mauris sit amet rutrum ipsum. Nulla ultrices facilisis nisi et interdum. Donec eu aliquet libero, eget blandit magna. Integer facilisis risus leo, sed porta ex ornare eu."
                },

                new Review
                {
                    Id = "066",
                    MovieId = "041",
                    PersonId = "035", Star = 4,
                    DateGmt = new DateTime(2021, 8, 9),
                    Text = "Phasellus pretium varius aliquam. In semper ipsum eget ex porta, vel hendrerit urna aliquam. Aliquam arcu ante, vestibulum ac egestas sed, semper dignissim urna. Morbi eu nunc malesuada, ultrices orci non, auctor magna. Ut sit amet libero tempor, eleifend dui a, imperdiet massa."
                },

                new Review
                {
                    Id = "067",
                    MovieId = "025",
                    PersonId = "006",
                    Star = 3,
                    DateGmt = new DateTime(2021, 8, 12),
                    Text = "Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Etiam vitae mauris consequat, semper turpis quis, fringilla ligula. Cras in nunc dapibus tellus cursus finibus a a dolor. Sed hendrerit fringilla tellus, ut dignissim ipsum iaculis nec. Phasellus fermentum magna sapien, quis varius felis viverra vitae. Proin cursus tortor purus, a vehicula erat luctus viverra. Nunc diam turpis, tempus id lobortis at, tempus non ante. Sed eget massa iaculis, accumsan lorem vehicula, placerat metus. Morbi congue orci volutpat nisl rutrum efficitur. Fusce volutpat tortor tortor, ac mattis arcu laoreet nec. Morbi tortor felis, luctus at ipsum ac, rhoncus elementum erat. Maecenas egestas fermentum lorem at varius."
                },

                new Review
                {
                    Id = "068",
                    MovieId = "027",
                    PersonId = "014",
                    Star = 4,
                    DateGmt = new DateTime(2021, 8, 14),
                    Text = "Aliquam vitae feugiat libero. Mauris semper ipsum arcu, sit amet auctor tellus hendrerit vitae. Fusce auctor vel lorem id eleifend. Nunc mollis sem sit amet velit convallis dignissim. Sed non nibh malesuada, dapibus nulla quis, egestas lectus. Aenean sit amet vulputate justo, efficitur tristique tortor."
                },

                new Review
                {
                    Id = "069",
                    MovieId = "033",
                    PersonId = "022",
                    Star = 5,
                    DateGmt = new DateTime(2021, 8, 18),
                    Text = "Morbi venenatis sem nec est facilisis consequat."
                },

                new Review
                {
                    Id = "070",
                    MovieId = "052",
                    PersonId = "039",
                    Star = 4,
                    DateGmt = new DateTime(2021, 8, 20),
                    Text = "Vivamus facilisis, sapien eu scelerisque pulvinar, justo neque convallis nunc, non auctor urna risus dictum sem. Duis eget luctus eros, vel iaculis magna. Donec vel sagittis dui. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Pellentesque lorem mi, egestas ac eleifend in, vulputate vitae tellus. Duis vehicula, diam ut euismod laoreet, neque odio luctus leo, a tempor velit neque non nisl. Sed dictum auctor erat, non congue elit lacinia nec. Fusce ac libero eu leo pharetra rhoncus. Etiam vitae sem in magna feugiat eleifend. Quisque tincidunt consequat nulla, sed eleifend nunc hendrerit at. Vestibulum dictum velit eget ligula vehicula eleifend. Praesent et nibh porttitor metus blandit malesuada in sed nulla. Donec mollis vel urna a feugiat."
                },

                new Review
                {
                    Id = "071",
                    MovieId = "011",
                    PersonId = "043",
                    Star = 3,
                    DateGmt = new DateTime(2021, 8, 21),
                    Text = "Duis libero orci, varius in nibh sed, scelerisque imperdiet turpis. In congue ultricies libero, sit amet scelerisque libero ullamcorper sit amet. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Interdum et malesuada fames ac ante ipsum primis in faucibus. Proin suscipit velit ac egestas efficitur. Etiam semper sagittis lobortis."
                },

                new Review
                {
                    Id = "072",
                    MovieId = "032",
                    PersonId = "055",
                    Star = 1,
                    DateGmt = new DateTime(2021, 8, 23),
                    Text = "Nam ornare est massa, ac pharetra mi ullamcorper non. Praesent molestie est massa, et placerat risus congue id. Sed dignissim congue nisl, vitae euismod purus convallis malesuada. Vivamus ornare sollicitudin ipsum, ac aliquam nibh sagittis id. Fusce volutpat, arcu nec gravida fermentum, velit tellus laoreet est, sit amet tristique elit velit ut odio. Pellentesque cursus leo ligula, ac egestas magna semper at."
                },

                new Review
                {
                    Id = "073",
                    MovieId = "040",
                    PersonId = "041",
                    Star = 5,
                    DateGmt = new DateTime(2021, 8, 30),
                    Text = "Nunc eget sollicitudin velit, ut porta leo. In lobortis sit amet quam in iaculis. Donec non egestas orci. Suspendisse nec risus sit amet purus venenatis lacinia. Curabitur vehicula quam at nisi dapibus tempus. Nam eu justo eu nulla finibus vestibulum. Mauris eu est feugiat, tempus dolor sed, eleifend augue."
                },

                new Review
                {
                    Id = "074",
                    MovieId = "039",
                    PersonId = "039",
                    Star = 4,
                    DateGmt = new DateTime(2021, 9, 1),
                    Text = "Fusce porta diam sed lacinia pretium. Nulla finibus, ante sed dapibus hendrerit, ipsum eros gravida tellus, non faucibus nibh lacus vulputate est. Vivamus a volutpat velit. Phasellus quis mi non risus imperdiet gravida a vitae urna. Vivamus eu nibh sed sapien vestibulum feugiat ornare eu lorem. Sed vel odio quis purus dictum imperdiet ac at neque. Phasellus congue sit amet enim ut luctus. Suspendisse eget nisl quis est efficitur mollis. Nulla scelerisque nulla et gravida interdum. Cras laoreet tortor dolor, sed varius nisi gravida dictum. Quisque rhoncus nibh erat, id imperdiet felis sodales a. Praesent maximus auctor turpis, at hendrerit justo faucibus a. Curabitur vel tellus posuere, tristique justo vel, aliquet massa. Maecenas consequat eros purus, quis sodales mauris tristique ac."
                },

                new Review
                {
                    Id = "075",
                    MovieId = "040",
                    PersonId = "024",
                    Star = 2,
                    DateGmt = new DateTime(2021, 9, 4),
                    Text = "Duis et feugiat urna. Sed sit amet porttitor sem. Aenean eget pellentesque nibh, in imperdiet mauris. Mauris ut egestas lacus, fringilla scelerisque est. Duis quis elementum dui. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Praesent ac lectus vitae urna consequat tristique at porta tortor. Integer orci mauris, feugiat sit amet suscipit eget, interdum in dolor."
                },

                new Review
                {
                    Id = "076",
                    MovieId = "010",
                    PersonId = "032",
                    Star = 3,
                    DateGmt = new DateTime(2021, 9, 8),
                    Text = "Maecenas maximus aliquam orci, non vehicula leo posuere varius. Nullam lacus augue, dapibus malesuada euismod quis, placerat quis erat. Nunc feugiat placerat lacus sed blandit. Fusce vel augue ante. Sed hendrerit mauris sit amet arcu aliquet, ut pellentesque enim dictum. Nam eu nisl eget tellus fringilla faucibus. Pellentesque in mi ipsum. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam nec cursus mi. Donec non libero ac nulla euismod tempus ac sed purus. Nunc eget cursus tortor. Aenean ullamcorper elit sed felis eleifend, eget vulputate urna sodales. Donec eu neque et turpis elementum placerat. Donec pulvinar consectetur odio sit amet gravida."
                },

                new Review
                {
                    Id = "077",
                    MovieId = "041",
                    PersonId = "019",
                    Star = 3,
                    DateGmt = new DateTime(2021, 9, 12),
                    Text = "Donec varius enim sagittis tortor egestas scelerisque. Nulla pulvinar est in ligula pretium pharetra. Sed luctus convallis mi in efficitur. Duis a mi feugiat, tristique urna in, tincidunt orci. Donec mi lorem, tempor nec imperdiet tempus, faucibus et est. Curabitur quis aliquet libero. Nulla efficitur laoreet tortor quis pharetra. Vestibulum faucibus nisl tempus, ultrices felis sodales, pharetra neque. Mauris tempus bibendum mi, a malesuada nisi pretium vel."
                },

                new Review
                {
                    Id = "078",
                    MovieId = "023",
                    PersonId = "040",
                    Star = 4,
                    DateGmt = new DateTime(2021, 9, 15),
                    Text = "Suspendisse sollicitudin, velit vitae dignissim hendrerit, dui ante viverra tellus, in porta arcu velit at tortor. Sed quis elit ac urna mattis luctus. Sed ante arcu, pulvinar id enim semper, molestie varius ipsum. Cras at dolor non nisl commodo fringilla id ac magna."
                },

                new Review
                {
                    Id = "079",
                    MovieId = "039",
                    PersonId = "038",
                    Star = 2,
                    DateGmt = new DateTime(2021, 9, 19),
                    Text = "Curabitur vehicula libero mi, eget iaculis nibh elementum non. Nunc maximus metus elementum neque maximus, non viverra sapien venenatis."
                },

                new Review
                {
                    Id = "080",
                    MovieId = "24",
                    PersonId = "048",
                    Star = 4,
                    DateGmt = new DateTime(2021, 9, 20),
                    Text = "Pellentesque quis quam urna. Morbi vel sem ut turpis vehicula elementum ac ac turpis. Suspendisse venenatis, arcu eu fringilla consectetur, metus ipsum pulvinar magna, in tincidunt dolor erat a nisi. Ut blandit lorem efficitur est lobortis, eu egestas purus pellentesque. Quisque faucibus vitae libero eget maximus."
                },

                new Review
                {
                    Id = "081",
                    MovieId = "009",
                    PersonId = "016",
                    Star = 3,
                    DateGmt = new DateTime(2021, 9, 22),
                    Text = "Aliquam sit amet rutrum lacus."
                },

                new Review
                {
                    Id = "082",
                    MovieId = "005",
                    PersonId = "030",
                    Star = 5,
                    DateGmt = new DateTime(2021, 10, 24),
                    Text = "Aenean porttitor eleifend ipsum, sit amet sodales justo scelerisque et. Pellentesque vehicula sodales ex ac sodales. Donec volutpat felis ipsum, id blandit arcu laoreet ac. Phasellus id nibh cursus, lacinia ex ac, faucibus enim. Sed tincidunt urna egestas nulla dignissim tempor. Integer finibus pellentesque neque consequat aliquet. Nullam at laoreet nisl, vitae luctus dui. Mauris interdum nulla nibh, ut rhoncus sapien ultricies non. Nulla vitae tristique nibh. Aenean pulvinar, tellus sit amet cursus pretium, nisi odio tincidunt felis, vitae consectetur nibh erat ut eros."
                },

                new Review
                {
                    Id = "083",
                    MovieId = "006",
                    PersonId = "059",
                    Star = 4,
                    DateGmt = new DateTime(2021, 10, 24),
                    Text = "Donec iaculis interdum erat non ullamcorper. Aliquam et suscipit nisl. Phasellus pulvinar, est eget viverra auctor, ipsum nulla tempus tortor, eget volutpat felis libero quis enim. Pellentesque in ipsum at nibh dictum aliquet. Sed molestie auctor arcu, a pretium dui aliquam vel. Fusce tincidunt suscipit condimentum. Duis ut commodo mi."
                },

                new Review
                {
                    Id = "084",
                    MovieId = "033",
                    PersonId = "046",
                    Star = 3,
                    DateGmt = new DateTime(2021, 10, 26),
                    Text = "Praesent id diam in justo varius maximus. Quisque at nulla nulla."
                },

                new Review
                {
                    Id = "085",
                    MovieId = "053",
                    PersonId = "053",
                    Star = 4,
                    DateGmt = new DateTime(2021, 10, 26),
                    Text = "Pellentesque in mi dolor. Ut et arcu eu diam tincidunt sollicitudin. Phasellus at diam euismod, tincidunt lacus eu, facilisis ex. Sed risus felis, pretium et dapibus a, euismod sed dui. Phasellus varius libero eget ultrices faucibus. Etiam suscipit feugiat ornare. Mauris eget elementum est, ac pellentesque urna. Aenean ultricies sagittis sem et dictum. Aenean sodales sed urna at ultricies. Nunc porttitor diam pulvinar massa molestie, in finibus nisi egestas. Sed in arcu a turpis volutpat pulvinar nec non felis."
                },

                new Review
                {
                    Id = "086",
                    MovieId = "009",
                    PersonId = "059",
                    Star = 2,
                    DateGmt = new DateTime(2021, 10, 27),
                    Text = "Vivamus dapibus ipsum at ultrices imperdiet. Donec elit mi, vulputate nec lacinia et, tempus ac mauris. Nunc massa nulla, eleifend a dui ut, sollicitudin scelerisque ipsum. Proin nisl neque, pellentesque nec tristique in, rutrum nec dolor. Integer eget velit ac leo pretium facilisis. Suspendisse potenti. Sed sem massa, suscipit ut risus tempus, convallis dapibus urna. Sed convallis metus sit amet fermentum sodales."
                },

                new Review
                {
                    Id = "087",
                    MovieId = "012",
                    PersonId = "060",
                    Star = 5,
                    DateGmt = new DateTime(2021, 10, 28),
                    Text = "Nam lobortis mauris ut nunc suscipit, in blandit augue semper. Phasellus vehicula, urna a malesuada porta, ex orci gravida nunc, ac sodales turpis felis ut purus."
                },

                new Review
                {
                    Id = "088",
                    MovieId = "017",
                    PersonId = "009",
                    Star = 3,
                    DateGmt = new DateTime(2021, 10, 29),
                    Text = "Proin rhoncus justo vel ex finibus efficitur. Nam interdum urna eu malesuada faucibus. Integer molestie nisl ut tellus euismod, ut commodo est egestas. Vestibulum lobortis in sapien ac faucibus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur pulvinar euismod enim a eleifend. Proin ullamcorper risus id velit efficitur dictum."
                },

                new Review
                {
                    Id = "089",
                    MovieId = "034",
                    PersonId = "015",
                    Star = 1,
                    DateGmt = new DateTime(2021, 10, 30),
                    Text = "Quisque mattis elit a magna consequat, sed luctus felis ultricies. Proin malesuada nulla vitae lacus ullamcorper semper. Curabitur egestas turpis a congue facilisis. Aenean tincidunt ut nulla id hendrerit. Etiam non rutrum elit. Morbi vestibulum dictum sapien, sed pellentesque odio fermentum id. Vestibulum ac massa a tortor luctus vestibulum. Nam non tellus sit amet diam volutpat pulvinar sed quis lorem."
                },

                new Review
                {
                    Id = "090",
                    MovieId = "037",
                    PersonId = "002",
                    Star = 2,
                    DateGmt = new DateTime(2021, 10, 30),
                    Text = "Curabitur ac diam nec urna commodo efficitur nec sed sapien. Morbi quam mi, accumsan eget nisi a, pellentesque malesuada purus."
                },

                new Review
                {
                    Id = "091",
                    MovieId = "054",
                    PersonId = "030",
                    Star = 5,
                    DateGmt = new DateTime(2021, 10, 31),
                    Text = "Sed porta ultricies risus eu laoreet. Etiam convallis, enim in varius varius, felis tellus tincidunt neque, non ullamcorper nisi neque at mauris. Vivamus posuere laoreet lectus. Donec rutrum hendrerit vestibulum."
                },

                new Review
                {
                    Id = "092",
                    MovieId = "024",
                    PersonId = "031",
                    Star = 4,
                    DateGmt = new DateTime(2021, 10, 31),
                    Text = "Proin pulvinar leo non orci eleifend cursus. Etiam ullamcorper, orci vel efficitur laoreet, lectus mi fermentum elit, et iaculis est nibh vel mi."
                },

                new Review
                {
                    Id = "093",
                    MovieId = "013",
                    PersonId = "047",
                    Star = 3,
                    DateGmt = new DateTime(2021, 10, 31),
                    Text = "Vivamus et suscipit sapien. Cras quis nisi luctus, tincidunt erat vitae, bibendum nunc."
                },

                new Review
                {
                    Id = "094",
                    MovieId = "035",
                    PersonId = "024",
                    Star = 2,
                    DateGmt = new DateTime(2021, 11, 3),
                    Text = "Mauris facilisis sapien vel justo vulputate, sed euismod nisl pharetra. Vivamus eget viverra massa. Nunc dignissim efficitur mi. Nunc dignissim suscipit iaculis. Suspendisse sit amet odio non eros ullamcorper tincidunt pretium id tellus. Quisque imperdiet ex sit amet sem scelerisque interdum."
                },

                new Review
                {
                    Id = "095",
                    MovieId = "041",
                    PersonId = "048",
                    Star = 3,
                    DateGmt = new DateTime(2021, 11, 4),
                    Text = "Curabitur sit amet justo placerat, condimentum metus ut, ullamcorper arcu. Duis gravida nunc lacus, in bibendum felis fermentum non. Integer luctus nibh a lorem rhoncus, id finibus odio tincidunt. Vivamus mi purus, sagittis in eleifend id, pharetra et mi. Sed non sollicitudin diam."
                },

                new Review
                {
                    Id = "096",
                    MovieId = "024",
                    PersonId = "011",
                    Star = 4,
                    DateGmt = new DateTime(2021, 11, 6),
                    Text = "Phasellus efficitur fringilla lorem, tincidunt hendrerit elit tempus vitae. Cras tortor ipsum, laoreet id vulputate a, pulvinar cursus ligula. Nunc sollicitudin tortor nunc, non lobortis nisi vulputate vel."
                },

                new Review
                {
                    Id = "097",
                    MovieId = "045",
                    PersonId = "002",
                    Star = 5,
                    DateGmt = new DateTime(2021, 11, 8),
                    Text = "Quisque sit amet libero in ipsum euismod rhoncus non a ex. Donec non pretium nibh. Donec vel arcu sed nisi sagittis porttitor ac quis metus. Aliquam a ante luctus, auctor turpis nec, hendrerit arcu. Morbi quis lectus nisl. Donec dapibus nisi at auctor blandit. Nullam aliquet elementum enim non volutpat. Maecenas ultrices sem sed justo dictum aliquet."
                },

                new Review
                {
                    Id = "098",
                    MovieId = "049",
                    PersonId = "009",
                    Star = 3,
                    DateGmt = new DateTime(2021, 11, 11),
                    Text = "Donec pharetra, felis at volutpat malesuada, sem ligula varius dui, eget porta erat sapien at erat. Integer malesuada nunc neque, porta commodo nulla commodo laoreet. In pharetra libero tellus, non venenatis libero vehicula nec. Donec vel nisl sapien. Aliquam erat volutpat."
                },

                new Review
                {
                    Id = "099",
                    MovieId = "055",
                    PersonId = "029",
                    Star = 2,
                    DateGmt = new DateTime(2021, 11, 14),
                    Text = "Cras porttitor arcu sit amet nisi feugiat, et fringilla leo varius. Quisque et sollicitudin augue. Etiam sit amet gravida magna, eget luctus neque. Nulla sed purus arcu. Morbi sapien tortor, gravida ut ullamcorper vitae, lacinia sit amet lectus. In hac habitasse platea dictumst."
                },

                new Review
                {
                    Id = "100",
                    MovieId = "008",
                    PersonId = "033",
                    Star = 3,
                    DateGmt = new DateTime(2021, 11, 16),
                    Text = "Etiam ultrices magna ligula, sed molestie quam faucibus sit amet."
                },

                new Review
                {
                    Id = "101",
                    MovieId = "022",
                    PersonId = "048",
                    Star = 2,
                    DateGmt = new DateTime(2021, 11, 17),
                    Text = "Vestibulum quis eleifend felis, non placerat lorem. Quisque nunc sapien, varius porttitor tortor vel, maximus convallis ante."
                },

                new Review
                {
                    Id = "102",
                    MovieId = "030",
                    PersonId = "055",
                    Star = 4,
                    DateGmt = new DateTime(2021, 11, 19),
                    Text = "Nunc ultrices in enim a consequat. Etiam fringilla orci ut leo scelerisque, pulvinar pellentesque arcu tristique. Vestibulum vulputate dapibus est, eget tincidunt diam aliquam a. Praesent viverra metus quis erat sagittis vehicula. Quisque neque orci, tempus eu lectus a, luctus feugiat felis."
                },

                new Review
                {
                    Id = "103",
                    MovieId = "040",
                    PersonId = "009",
                    Star = 5,
                    DateGmt = new DateTime(2021, 11, 20),
                    Text = "Nullam et risus at erat feugiat feugiat. Cras eu dignissim ante. Integer lacus sem, rhoncus sed neque quis, aliquet porta dui. Aenean consequat magna dolor, non vehicula dui posuere a."
                },

                new Review
                {
                    Id = "104",
                    MovieId = "056",
                    PersonId = "012", Star = 3,
                    DateGmt = new DateTime(2021, 11, 21),
                    Text = "Integer libero ligula, auctor vel aliquet ut, scelerisque in enim. Sed aliquam vitae leo ut dapibus. Nullam in vehicula ex. Ut finibus metus purus, ut porta nibh finibus sodales. Vestibulum lacinia pharetra nulla sit amet sollicitudin. Pellentesque malesuada cursus ex rhoncus luctus. Donec interdum tincidunt lorem eget tristique. Donec lobortis rhoncus gravida. Praesent in massa nisi. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Duis eu dignissim purus. In auctor ante in nunc accumsan lobortis."
                },

                new Review
                {
                    Id = "105",
                    MovieId = "036",
                    PersonId = "037",
                    Star = 4,
                    DateGmt = new DateTime(2021, 11, 22),
                    Text = "Donec id leo vitae lorem vulputate maximus ac at mauris. Sed et pharetra nisl. Pellentesque ac maximus lorem. Quisque purus turpis, fringilla placerat lobortis et, elementum porta felis. Suspendisse faucibus vel ante id lobortis. Nunc congue nec est quis ultrices. Donec volutpat, mauris id mattis iaculis, nunc elit facilisis mauris, non viverra massa nisl at risus. Mauris sit amet urna lobortis, sollicitudin tellus ullamcorper, viverra sem."
                },

                new Review
                {
                    Id = "106",
                    MovieId = "050",
                    PersonId = "046",
                    Star = 3,
                    DateGmt = new DateTime(2021, 11, 24),
                    Text = "In ex erat, lobortis sed nisi ut, venenatis euismod nunc. In ipsum sapien, congue sed ipsum a, porttitor hendrerit metus. Sed cursus libero ipsum, et dictum ipsum consectetur sit amet. Curabitur vitae lectus lobortis, mollis elit ac, mollis felis. Nullam arcu felis, sollicitudin vel convallis sit amet, molestie pharetra risus. Maecenas viverra quam id convallis finibus. Nunc id mi quis augue posuere egestas at ac libero."
                },

                new Review
                {
                    Id = "107",
                    MovieId = "055",
                    PersonId = "054",
                    Star = 5,
                    DateGmt = new DateTime(2021, 11, 29),
                    Text = "Phasellus in convallis mauris, eget sollicitudin massa. Sed quis urna massa. Sed venenatis fermentum diam, sit amet elementum justo lobortis et."
                },

                new Review
                {
                    Id = "108",
                    MovieId = "007",
                    PersonId = "033",
                    Star = 2,
                    DateGmt = new DateTime(2021, 12, 1),
                    Text = "Fusce semper auctor libero. Praesent eget lorem sit amet urna maximus molestie. Ut eu odio et dui scelerisque posuere nec nec arcu. Nulla facilisi."
                },

                new Review
                {
                    Id = "109",
                    MovieId = "023",
                    PersonId = "011",
                    Star = 3,
                    DateGmt = new DateTime(2021, 12, 3),
                    Text = "Vivamus eu ipsum ut urna gravida tempor non eget ligula. Fusce vitae gravida ante, a blandit turpis. Nunc sodales, velit id semper luctus, erat ante ullamcorper diam, a molestie libero sapien non mi. Duis leo libero, congue id nibh ac, ornare vestibulum eros. In sem ipsum, tincidunt nec nisi sed, aliquet pharetra dui."
                },

                new Review
                {
                    Id = "110",
                    MovieId = "019",
                    PersonId = "057",
                    Star = 4,
                    DateGmt = new DateTime(2021, 12, 7),
                    Text = "Proin non tellus eu magna gravida dapibus eu ac odio. Suspendisse potenti. Aliquam commodo varius elit, volutpat venenatis lorem. "
                },

                new Review
                {
                    Id = "111",
                    MovieId = "030",
                    PersonId = "011",
                    Star = 5,
                    DateGmt = new DateTime(2021, 12, 9),
                    Text = "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Maecenas bibendum neque sit amet eros ultricies, eget vehicula ex tincidunt. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; In lobortis, risus sit amet egestas laoreet, tellus tortor sollicitudin nibh, tempus vehicula augue tortor nec nulla."
                },

                new Review
                {
                    Id = "112",
                    MovieId = "050",
                    PersonId = "009",
                    Star = 4,
                    DateGmt = new DateTime(2021, 12, 12),
                    Text = "Nam dignissim at nunc placerat malesuada. Nullam et dolor nec justo dapibus cursus eu quis tellus. Ut vitae malesuada turpis. Duis id gravida justo, interdum elementum dui. Vivamus vel semper leo. Curabitur erat erat, ullamcorper non hendrerit eu, vestibulum a turpis."
                },

                new Review
                {
                    Id = "113",
                    MovieId = "001",
                    PersonId = "040",
                    Star = 4,
                    DateGmt = new DateTime(2021, 12, 13),
                    Text = "Quisque dignissim vel felis ac semper. Nam vel ligula massa. Fusce tincidunt odio vitae augue cursus, id placerat turpis bibendum. Curabitur mattis elit sem, id venenatis nibh sagittis ut. Maecenas in lobortis lectus. Duis malesuada quam at ipsum vulputate, quis iaculis nisi bibendum."
                },

                new Review
                {
                    Id = "114",
                    MovieId = "004",
                    PersonId = "053",
                    Star = 3,
                    DateGmt = new DateTime(2021, 12, 16),
                    Text = "Nunc in semper purus. Duis id turpis libero. Aenean rutrum fringilla felis, id ultrices felis. Sed aliquet ut purus eu luctus. Sed cursus luctus ante ut dignissim. Nullam vitae rutrum quam. Cras iaculis finibus nunc, sed faucibus erat elementum eget. Donec aliquam neque non orci porttitor, ac molestie ipsum finibus. Quisque tincidunt blandit varius. Fusce hendrerit, sapien a blandit sagittis, nunc nunc aliquet lectus, vel ultricies ligula lectus eu lacus."
                },

                new Review
                {
                    Id = "115",
                    MovieId = "037",
                    PersonId = "019",
                    Star = 5,
                    DateGmt = new DateTime(2021, 12, 17),
                    Text = "Phasellus dignissim tincidunt nunc at semper. Donec iaculis erat egestas, ultrices ante eu, ullamcorper lorem. Ut nulla neque, porttitor eu placerat eget, posuere non velit. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Phasellus sagittis felis dapibus erat accumsan luctus. Phasellus semper metus elit, ut malesuada lorem mollis ac. Praesent vestibulum orci a enim porta, vitae posuere felis vulputate. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Aliquam in dui consectetur tellus hendrerit finibus id at neque. Nulla non luctus tellus, eu sollicitudin libero. Nam placerat metus ex. Pellentesque at ullamcorper dolor."
                },

                new Review
                {
                    Id = "116",
                    MovieId = "009",
                    PersonId = "033",
                    Star = 4,
                    DateGmt = new DateTime(2021, 12, 19),
                    Text = "Curabitur at placerat ex, in pulvinar urna. Praesent accumsan diam et magna consequat rutrum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Vivamus et blandit felis, et scelerisque nulla. Nulla efficitur nibh at dui efficitur feugiat. Cras mi turpis, finibus nec convallis semper, laoreet id massa. Fusce ac nisi varius, pulvinar nisl condimentum, fermentum leo. Maecenas id purus id est consequat maximus eget convallis eros. Donec ut enim vel purus iaculis convallis vitae dictum quam. Nulla facilisis lectus at mi lacinia, nec molestie est dapibus. Mauris imperdiet libero dui, vel porta risus congue nec. Sed tempus elit metus, non pretium purus aliquet eu. Morbi eget ultrices nibh, sed ultrices purus."
                },

                new Review
                {
                    Id = "117",
                    MovieId = "012",
                    PersonId = "041",
                    Star = 3,
                    DateGmt = new DateTime(2021, 12, 20),
                    Text = "Integer tincidunt dolor at nibh dictum maximus. Curabitur at erat nisl. Donec id purus dignissim, vestibulum eros id, pharetra lacus. Pellentesque hendrerit, est vulputate pretium euismod, ex nisl rutrum mi, ut tempus elit nisi in mauris. Praesent at lorem non odio maximus iaculis."
                },

                new Review
                {
                    Id = "118",
                    MovieId = "038",
                    PersonId = "002", Star = 2,
                    DateGmt = new DateTime(2021, 12, 22),
                    Text = "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; In euismod volutpat nibh, non faucibus dui luctus ac. Donec euismod dolor vitae pharetra mattis. Aliquam erat volutpat. Donec posuere nec arcu vel fringilla. In hac habitasse platea dictumst. Praesent dui sem, mollis at massa finibus, sollicitudin porta arcu. Sed eleifend turpis sed odio egestas, in blandit dolor maximus."
                },

                new Review
                {
                    Id = "119",
                    MovieId = "027",
                    PersonId = "034",
                    Star = 5,
                    DateGmt = new DateTime(2021, 12, 24),
                    Text = "Aenean auctor nibh gravida lorem iaculis, a sollicitudin nisl ullamcorper. Mauris aliquam velit vel tellus tincidunt, id elementum nulla mollis."
                },

                new Review
                {
                    Id = "120",
                    MovieId = "006",
                    PersonId = "050",
                    Star = 4,
                    DateGmt = new DateTime(2021, 12, 30),
                    Text = "Proin nulla ligula, fermentum vitae congue ac, rhoncus vel massa. Phasellus consectetur risus erat, at facilisis dolor imperdiet in. Duis ac ligula aliquam, pulvinar eros nec, gravida dolor. Pellentesque iaculis ex nisl, a consectetur eros feugiat mattis. Fusce facilisis sollicitudin nisl, condimentum mollis risus pulvinar vitae."
                },

            };
        }
    }
}

