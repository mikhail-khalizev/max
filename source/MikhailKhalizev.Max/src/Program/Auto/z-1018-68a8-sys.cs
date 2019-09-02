using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_68a8-fde93429")]
        public void /* sys */ Method_1018_68a8()
        {
            ii(0x1018_68a8, 1); push(ebx);                              /* push ebx */
            ii(0x1018_68a9, 1); push(ecx);                              /* push ecx */
            ii(0x1018_68aa, 1); push(esi);                              /* push esi */
            ii(0x1018_68ab, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1018_68ad, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1018_68af, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1018_68b1, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_68b3, 2); xor(esi, esi);                          /* xor esi, esi */
            ii(0x1018_68b5, 5); call(/* sys */ 0x1016_f5bc, -0x1_72fe); /* call 0x1016f5bc */
            ii(0x1018_68ba, 3); cmp(eax, -1 /* 0xff */);                /* cmp eax, 0xffffffff */
            ii(0x1018_68bd, 6); if(jz(0x1018_6972, 0xaf)) goto l_0x1018_6972; /* jz 0x10186972 */
            ii(0x1018_68c3, 3); lea(edx, memd[ds, ecx + 4]);            /* lea edx, [ecx+0x4] */
            ii(0x1018_68c6, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_68c8, 5); call(/* sys */ 0x1016_f5bc, -0x1_7311); /* call 0x1016f5bc */
            ii(0x1018_68cd, 3); cmp(eax, -1 /* 0xff */);                /* cmp eax, 0xffffffff */
            ii(0x1018_68d0, 6); if(jz(0x1018_6972, 0x9c)) goto l_0x1018_6972; /* jz 0x10186972 */
            ii(0x1018_68d6, 3); lea(edx, memd[ds, ecx + 8]);            /* lea edx, [ecx+0x8] */
            ii(0x1018_68d9, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_68db, 5); call(/* sys */ 0x1016_f5bc, -0x1_7324); /* call 0x1016f5bc */
            ii(0x1018_68e0, 3); cmp(eax, -1 /* 0xff */);                /* cmp eax, 0xffffffff */
            ii(0x1018_68e3, 6); if(jz(0x1018_6972, 0x89)) goto l_0x1018_6972; /* jz 0x10186972 */
            ii(0x1018_68e9, 2); mov(eax, memd[ds, ecx]);                /* mov eax, [ecx] */
            ii(0x1018_68eb, 3); cmp(eax, 3);                            /* cmp eax, 0x3 */
            ii(0x1018_68ee, 6); if(ja(0x1018_6972, 0x7e)) goto l_0x1018_6972; /* ja 0x10186972 */
            ii(0x1018_68f4, 8); 
            switch (jmp_abs_switch(memd[cs, eax * 4 + /* sys */ 0x1018_6898]))
            {
                case 0x1018_68fc:
                    goto l_0x1018_68fc;
                case 0x1018_692f:
                    goto l_0x1018_692f;
                case 0x1018_6940:
                    goto l_0x1018_6940;
                case 0x1018_6972:
                    goto l_0x1018_6972;
                default:
                    throw new NotImplementedException();
            } /* jmp dword [cs:eax*4+0x10186898] */
        l_0x1018_68fc:
            ii(0x1018_68fc, 3); lea(edx, memd[ds, ecx + 0xc]);          /* lea edx, [ecx+0xc] */
            ii(0x1018_68ff, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_6901, 5); call(/* sys */ 0x1016_f5bc, -0x1_734a); /* call 0x1016f5bc */
            ii(0x1018_6906, 3); cmp(eax, -1 /* 0xff */);                /* cmp eax, 0xffffffff */
            ii(0x1018_6909, 6); if(jz(0x1018_6972, 0x63)) goto l_0x1018_6972; /* jz 0x10186972 */
            ii(0x1018_690f, 3); lea(edx, memd[ds, ecx + 0x10]);         /* lea edx, [ecx+0x10] */
            ii(0x1018_6912, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_6914, 5); call(/* sys */ 0x1016_f5bc, -0x1_735d); /* call 0x1016f5bc */
            ii(0x1018_6919, 3); cmp(eax, -1 /* 0xff */);                /* cmp eax, 0xffffffff */
            ii(0x1018_691c, 2); if(jz(0x1018_6972, 0x54)) goto l_0x1018_6972; /* jz 0x10186972 */
            ii(0x1018_691e, 3); lea(edx, memd[ds, ecx + 0x14]);         /* lea edx, [ecx+0x14] */
            ii(0x1018_6921, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_6923, 5); call(/* sys */ 0x1016_f5bc, -0x1_736c); /* call 0x1016f5bc */
            ii(0x1018_6928, 3); cmp(eax, -1 /* 0xff */);                /* cmp eax, 0xffffffff */
            ii(0x1018_692b, 2); if(jz(0x1018_6972, 0x45)) goto l_0x1018_6972; /* jz 0x10186972 */
            ii(0x1018_692d, 2); jmp(0x1018_696d, 0x3e); goto l_0x1018_696d; /* jmp 0x1018696d */
        l_0x1018_692f:
            ii(0x1018_692f, 3); lea(edx, memd[ds, ecx + 0xc]);          /* lea edx, [ecx+0xc] */
            ii(0x1018_6932, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_6934, 5); call(/* sys */ 0x1016_f55c, -0x1_73dd); /* call 0x1016f55c */
            ii(0x1018_6939, 3); cmp(eax, -1 /* 0xff */);                /* cmp eax, 0xffffffff */
            ii(0x1018_693c, 2); if(jz(0x1018_6972, 0x34)) goto l_0x1018_6972; /* jz 0x10186972 */
            ii(0x1018_693e, 2); jmp(0x1018_696d, 0x2d); goto l_0x1018_696d; /* jmp 0x1018696d */
        l_0x1018_6940:
            ii(0x1018_6940, 3); lea(edx, memd[ds, ecx + 0xc]);          /* lea edx, [ecx+0xc] */
            ii(0x1018_6943, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_6945, 5); call(/* sys */ 0x1016_f5bc, -0x1_738e); /* call 0x1016f5bc */
            ii(0x1018_694a, 3); cmp(eax, -1 /* 0xff */);                /* cmp eax, 0xffffffff */
            ii(0x1018_694d, 2); if(jz(0x1018_6972, 0x23)) goto l_0x1018_6972; /* jz 0x10186972 */
            ii(0x1018_694f, 3); lea(edx, memd[ds, ecx + 0x10]);         /* lea edx, [ecx+0x10] */
            ii(0x1018_6952, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_6954, 5); call(/* sys */ 0x1016_f5bc, -0x1_739d); /* call 0x1016f5bc */
            ii(0x1018_6959, 3); cmp(eax, -1 /* 0xff */);                /* cmp eax, 0xffffffff */
            ii(0x1018_695c, 2); if(jz(0x1018_6972, 0x14)) goto l_0x1018_6972; /* jz 0x10186972 */
            ii(0x1018_695e, 3); lea(edx, memd[ds, ecx + 0x14]);         /* lea edx, [ecx+0x14] */
            ii(0x1018_6961, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_6963, 5); call(/* sys */ 0x1016_f5bc, -0x1_73ac); /* call 0x1016f5bc */
            ii(0x1018_6968, 3); cmp(eax, -1 /* 0xff */);                /* cmp eax, 0xffffffff */
            ii(0x1018_696b, 2); if(jz(0x1018_6972, 5)) goto l_0x1018_6972; /* jz 0x10186972 */
        l_0x1018_696d:
            ii(0x1018_696d, 5); mov(esi, 1);                            /* mov esi, 0x1 */
        l_0x1018_6972:
            ii(0x1018_6972, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1018_6974, 1); pop(esi);                               /* pop esi */
            ii(0x1018_6975, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_6976, 1); pop(ebx);                               /* pop ebx */
            ii(0x1018_6977, 1); ret();                                  /* ret */
        }
    }
}
