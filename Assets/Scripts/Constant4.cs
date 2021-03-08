using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constant4 : MonoBehaviour
{
    public static string[] endingwithtion={"differentiation", "instrumentation", "dissatisfaction", "experimentation", "rationalization", "indemnification", "hospitalization", "discontinuation", "personification", "desertification", "excommunication", "nonprescription", "preregistration", "transfiguration", "vascularization", "ultrafiltration", "autocorrelation", "intermodulation", "exemplification", "acclimatization", "maldistribution", "circumscription", "nonintervention", "photoionization", "codetermination", "complementation", "reaccreditation", "misconstruction", "intussusception", "radioprotection", "decarboxylation", "hypercorrection", "antivivisection", "microdissection", "photoproduction", "underproduction", "hyperproduction", "misrecollection", "interconnection", "retroreflection", "microprojection", "counterreaction", "semiabstraction", "synchronization", "circularization", "formularization", "familiarization", "masculinization", "suboptimization", "suburbanization", "dichotomization", "prussianization", "civilianization", "disorganization", "suborganization", "alphabetization", "hypostatization", "reprivatization", "democratization", "demagnetization", "proselytization", "desensitization", "systematization", "mathematization", "phosphatization", "desulfurization", "miniaturization", "interiorization", "exteriorization", "reauthorization", "deglamorization", "parametrization", "decarburization", "extemporization", "conveyorization", "oligomerization", "catheterization", "computerization", "overconsumption", "superimposition", "counterpetition", "misdistribution", "counterquestion", "hyperinvolution", "phosphorylation", "cyanoethylation", "intrapopulation", "interpopulation", "disarticulation", "postinoculation", "overstimulation", "poststimulation", "circumvallation", "precancellation", "overspeculation", "antispeculation", "indetermination", "redetermination", "postpollination", "administration", "identification", "representation", "interpretation", "transportation", "transformation", "recommendation", "discrimination", "classification", "reconciliation", "reconstruction", "reorganization", "specialization", "capitalization", "redistribution", "disintegration", "stratification", "generalization", "multiplication", "predisposition", "deconstruction", "postproduction", "disorientation", "detoxification", "superannuation", "disinformation", "overpopulation", "conglomeration", "gentrification", "polymerization", "neutralization", "pasteurization", "congratulation", "bioremediation", "hyperinflation", "predestination", "disinclination", "recapitulation", "proprioception", "circumspection", "blaxploitation", "prepublication", "decompensation", "disapprobation", "undernutrition", "circumlocution", "incoordination", "superinfection", "noncooperation", "superscription", "microinjection", "defenestration", "lateralization", "exponentiation", "automatization", "esterification", "repolarization", "microevolution", "saponification", "nondisjunction", "superelevation", "concelebration", "osmoregulation", "macroevolution", "contraposition", "chemoreception", "depigmentation", "autosuggestion", "photoreception", "neurosecretion", "ammonification", "fructification", "subinfeudation", "transamination", "redintegration", "overproportion", "circumvolution", "thermojunction", "sclerotization", "parasitization", "prioritization", "securitization", "traumatization", "stigmatization", "derivatization", "demonetization", "remonetization", "concretization", "graphitization", "dolomitization", "symmetrization", "decolorization", "revalorization", "pressurization", "geometrization", "schematization", "bowdlerization", "weatherization", "allegorization", "categorization", "communication", "consideration", "investigation", "participation", "concentration", "determination", "demonstration", "configuration", "documentation", "qualification", "specification", "consolidation", "accommodation", "certification", "justification", "contamination", "confrontation", "transcription", "authorization", "accreditation", "contradiction", "appropriation", "manifestation", "preoccupation", "fragmentation", "amplification", "contraception", "constellation", "confederation", "contemplation", "pronunciation", "approximation", "precipitation", "gratification", "juxtaposition", "misconception", "fertilization", "decomposition", "consternation", "magnification", "commemoration", "introspection", "sedimentation", "sterilization", "contravention", "reincarnation", "orchestration", "signification", "preproduction", "acculturation", "recombination", "conflagration", "discoloration", "ornamentation", "triangulation", "transposition", "sequestration", "argumentation", "calcification", "fortification", "strangulation", "agglomeration", "recrimination", "individuation", "translocation", "hallucination", "mystification", "malabsorption", "transmutation", "superposition", "subpopulation", "reverberation", "mortification", "scintillation", "miscegenation", "dramatization", "nullification", "preconception", "disproportion", "agglutination", "republication", "reciprocation", "transpiration", "magnetization", "premeditation", "structuration", "commiseration", "degranulation", "disinhibition", "teleportation", "resegregation", "antipollution", "indisposition", "carbonization", "sexploitation", "prefiguration", "gesticulation", "maladaptation", "perseveration", "distribution", "organization", "construction", "amortization", "introduction", "presentation", "contribution", "compensation", "registration", "satisfaction", "installation", "conversation", "conservation", "constitution", "illustration", "appreciation", "subscription", "depreciation", "consultation", "jurisdiction", "confirmation", "prescription", "modification", "continuation", "anticipation", "reproduction", "acceleration", "exploitation", "verification", "cancellation", "coordination", "manipulation", "accumulation", "notification", "congregation", "civilization", "inflammation", "substitution", "intersection", "regeneration", "segmentation", "optimization", "resurrection", "cogeneration", "condemnation", "purification", "illumination", "complication", "prostitution", "assimilation", "remuneration", "dissertation", "consummation", "articulation", "emancipation", "interception", "polarization", "proclamation", "recollection", "inauguration", "amalgamation", "deliberation", "constipation", "degeneration", "condensation", "infiltration", "malnutrition", "fermentation", "denomination", "superstition", "implantation", "colonization", "augmentation", "precondition", "facilitation", "distillation", "exasperation", "commendation", "annihilation", "perspiration", "insurrection", "masturbation", "exhilaration", "dissociation", "denunciation", "menstruation", "intoxication", "conscription", "renunciation", "abbreviation", "superstation", "fibrillation", "dispensation", "conformation", "predilection", "consecration", "transduction", "capitulation", "embolization", "constriction", "information", "application", "association", "competition", "corporation", "combination", "acquisition", "recognition", "integration", "transaction", "legislation", "description", "institution", "publication", "preparation", "consumption", "examination", "exploration", "interaction", "explanation", "distinction", "instruction", "composition", "cooperation", "destination", "observation", "translation", "destruction", "proposition", "imagination", "expectation", "circulation", "restoration", "calculation", "declaration", "resignation", "negotiation", "inspiration", "penetration", "orientation", "frustration", "correlation", "conjunction", "termination", "speculation", "prosecution", "reservation", "disposition", "realization", "restriction", "implication", "designation", "arbitration", "degradation", "ventilation", "compilation", "replication", "dissolution", "fascination", "prohibition", "contraction", "deprivation", "cultivation", "computation", "duplication", "abstraction", "distraction", "affirmation", "segregation", "desperation", "consolation", "inclination", "obstruction", "humiliation", "presumption", "persecution", "reformation", "reclamation", "dysfunction", "calibration", "incarnation", "propagation", "vaccination", "restitution", "indignation", "retribution", "inscription", "provocation", "attribution", "retardation", "punctuation", "importation", "deformation", "remediation", "dissipation", "dislocation", "extradition", "deportation", "dehydration", "production", "population", "protection", "generation", "collection", "foundation", "obligation", "connection", "completion", "resolution", "reputation", "definition", "opposition", "transition", "convention", "innovation", "regulation", "exhibition", "revolution", "proportion", "prevention", "limitation", "indication", "assumption", "perception", "inspection", "federation", "separation", "reflection", "automation", "suggestion", "invitation", "recreation", "occupation", "discretion", "conviction", "dedication", "motivation", "navigation", "attraction", "correction", "redemption", "corruption", "simulation", "conception", "liberation", "absorption", "delegation", "projection", "prediction", "adaptation", "medication", "extraction", "nomination", "initiation", "revelation", "contention", "injunction", "relaxation", "temptation", "domination", "exposition", "vegetation", "alteration", "admiration", "expedition", "repetition", "perfection", "filtration", "inhibition", "insulation", "distortion", "deposition", "imposition", "demolition", "ammunition", "combustion", "estimation", "graduation", "decoration", "meditation", "irritation", "extinction", "evacuation", "expiration", "plantation", "hesitation", "exhaustion", "alienation", "saturation", "excavation", "resumption", "allegation", "nonfiction", "incubation", "starvation", "accusation", "sanitation", "aspiration", "infarction", "education", "operation", "attention", "situation", "condition", 
    "direction", "selection", "reduction", "tradition", "intention", "formation", "felicitation","promotion", "evolution", "exception", "inflation", "execution", "pollution", "coalition", "reception", "infection", "migration", "detection", "variation", "retention", "isolation", "valuation", "radiation", "injection", "exemption", "rejection", "inception", "nutrition", "sensation", "invention", "violation", "animation", "affection", "assertion", "detention", "probation", "deduction", "quotation", "induction", "objection", "addiction", "depletion", "vibration", "insertion", "deviation", "elevation", "deception", "mediation", "abolition", "emulation", "imitation", "secretion", "partition", "digestion", "intuition", "cessation", "accretion", "agitation", "oxidation", "attrition", "flotation", "rendition", "narration", "excretion", "causation", "gestation", "cognition", "dictation", "commotion", "resection", "seduction", "deflation", "iteration", "extortion", "adoration", "summation", "evocation", "adulation", "predation", "lactation", "desertion", "titration", "damnation", "carnation", "erudition", "gradation", "apportion", "collation", "privation", "epilation", "avocation", "dejection", "perdition", "pulsation", "redaction", "position", "question", "solution", "addition", "function", "location", "election", "creation", "reaction", "relation", "duration", "taxation", "aviation", "fraction", "equation", "petition", "junction", "rotation", "abortion", "donation", "vacation", "ambition", "dilution", "devotion", "friction", "citation", "traction", "mutation", "sanction", "notation", "audition", "fruition", "eruption", "ignition", "deletion", "vocation", "fixation", "erection", "inaction", "exertion", "ejection", "negation", "ablation", "sedation", "volition", "sedition", "novation", "ligation", "dilation", "adaption", "munition", "gumption", "legation", "volution", "vexation", "zonation", "libation", "gyration", "locution", "sorption", "gelation", "exaction", "stiction", "oblation", "ablution", "venation", "rogation", "natation", "potation", "halation", "conation", "nutation", "illation", "coaction", "flection", "evection", "remotion", "monition", "himation", "lunation", "lobation", "lavation", "dotation", "luxation", "laxation", "fetation", "aeration", "sudation", "ideation", "iodation", "nidation", "pupation", "agnation", "adnation", "solation", "delation", "punition", "lenition", "demotion", "adoption", "section", "station", "edition", "portion", "mention", "caption", "auction", "caution", "fiction", "emotion", "tuition", "faction", "ovation", "suction", "bastion", "diction", "oration", "unction", "lection", "enation", "ruction", "taction", "coition", "amotion", "elution", "paction", "elation", "alation", "action", "nation", "option", "motion", "notion", "ration", "lotion", "potion", "cation", "kation ", "ligation", "improvisation", "nonconstruction", "cogeneration", "alation", "workstation", "salvation", "detection"};// 842
    
}