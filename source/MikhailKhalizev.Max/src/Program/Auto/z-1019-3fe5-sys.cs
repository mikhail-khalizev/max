using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_3fe5-b6496006")]
        public void /* sys */ Method_1019_3fe5()
        {
            ii(0x1019_3fe5, 1); push(ebx);                              /* push ebx */
            ii(0x1019_3fe6, 1); push(ecx);                              /* push ecx */
            ii(0x1019_3fe7, 1); push(edx);                              /* push edx */
            ii(0x1019_3fe8, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_3fea, 3); shl(ecx, 2);                            /* shl ecx, 0x2 */
            ii(0x1019_3fed, 2); neg(ecx);                               /* neg ecx */
            ii(0x1019_3fef, 3); mov(memd[ss, ebp - 0x2c], ecx);         /* mov [ebp-0x2c], ecx */
            ii(0x1019_3ff2, 3); mov(ebx, memd[ss, ebp - 8]);            /* mov ebx, [ebp-0x8] */
            ii(0x1019_3ff5, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1019_3ff8, 6); sub(edi, memd[ds, Definitions.video_win_start]); /* sub edi, [0x10209ca8] */
            ii(0x1019_3ffe, 5); mov(ecx, /* sys */ 0x1019_40b8);        /* mov ecx, 0x101940b8 */
            ii(0x1019_4003, 6); if(jns(0x1019_4091, 0x88)) goto l_0x1019_4091; /* jns 0x10194091 */
            ii(0x1019_4009, 3); cmp(memd[ss, ebp - 0x2c], edi);         /* cmp [ebp-0x2c], edi */
            ii(0x1019_400c, 6); if(js(0x1019_40a1, 0x8f)) goto l_0x1019_40a1; /* js 0x101940a1 */
            ii(0x1019_4012, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1019_4014, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_4016, 5); mov(ecx, /* sys */ 0x1019_40c0);        /* mov ecx, 0x101940c0 */
            ii(0x1019_401b, 2); if(jns(0x1019_4091, 0x74)) goto l_0x1019_4091; /* jns 0x10194091 */
            ii(0x1019_401d, 3); cmp(memd[ss, ebp - 0x2c], edi);         /* cmp [ebp-0x2c], edi */
            ii(0x1019_4020, 2); if(js(0x1019_40a1, 0x7f)) goto l_0x1019_40a1; /* js 0x101940a1 */
            ii(0x1019_4022, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1019_4024, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_4026, 5); mov(ecx, /* sys */ 0x1019_40c8);        /* mov ecx, 0x101940c8 */
            ii(0x1019_402b, 2); if(jns(0x1019_4091, 0x64)) goto l_0x1019_4091; /* jns 0x10194091 */
            ii(0x1019_402d, 3); cmp(memd[ss, ebp - 0x2c], edi);         /* cmp [ebp-0x2c], edi */
            ii(0x1019_4030, 2); if(js(0x1019_40a1, 0x6f)) goto l_0x1019_40a1; /* js 0x101940a1 */
            ii(0x1019_4032, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1019_4034, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_4036, 5); mov(ecx, /* sys */ 0x1019_40d0);        /* mov ecx, 0x101940d0 */
            ii(0x1019_403b, 2); if(jns(0x1019_4091, 0x54)) goto l_0x1019_4091; /* jns 0x10194091 */
            ii(0x1019_403d, 3); cmp(memd[ss, ebp - 0x2c], edi);         /* cmp [ebp-0x2c], edi */
            ii(0x1019_4040, 2); if(js(0x1019_40a1, 0x5f)) goto l_0x1019_40a1; /* js 0x101940a1 */
            ii(0x1019_4042, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1019_4044, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_4046, 5); mov(ecx, /* sys */ 0x1019_40d8);        /* mov ecx, 0x101940d8 */
            ii(0x1019_404b, 2); if(jns(0x1019_4091, 0x44)) goto l_0x1019_4091; /* jns 0x10194091 */
            ii(0x1019_404d, 3); cmp(memd[ss, ebp - 0x2c], edi);         /* cmp [ebp-0x2c], edi */
            ii(0x1019_4050, 2); if(js(0x1019_40a1, 0x4f)) goto l_0x1019_40a1; /* js 0x101940a1 */
            ii(0x1019_4052, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1019_4054, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_4056, 5); mov(ecx, /* sys */ 0x1019_40e0);        /* mov ecx, 0x101940e0 */
            ii(0x1019_405b, 2); if(jns(0x1019_4091, 0x34)) goto l_0x1019_4091; /* jns 0x10194091 */
            ii(0x1019_405d, 3); cmp(memd[ss, ebp - 0x2c], edi);         /* cmp [ebp-0x2c], edi */
            ii(0x1019_4060, 2); if(js(0x1019_40a1, 0x3f)) goto l_0x1019_40a1; /* js 0x101940a1 */
            ii(0x1019_4062, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1019_4064, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_4066, 5); mov(ecx, /* sys */ 0x1019_40e8);        /* mov ecx, 0x101940e8 */
            ii(0x1019_406b, 2); if(jns(0x1019_4091, 0x24)) goto l_0x1019_4091; /* jns 0x10194091 */
            ii(0x1019_406d, 3); cmp(memd[ss, ebp - 0x2c], edi);         /* cmp [ebp-0x2c], edi */
            ii(0x1019_4070, 2); if(js(0x1019_40a1, 0x2f)) goto l_0x1019_40a1; /* js 0x101940a1 */
            ii(0x1019_4072, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1019_4074, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1019_4076, 5); mov(ecx, /* sys */ 0x1019_40f0);        /* mov ecx, 0x101940f0 */
            ii(0x1019_407b, 2); if(jns(0x1019_4091, 0x14)) goto l_0x1019_4091; /* jns 0x10194091 */
            ii(0x1019_407d, 3); cmp(memd[ss, ebp - 0x2c], edi);         /* cmp [ebp-0x2c], edi */
            ii(0x1019_4080, 2); if(js(0x1019_40a1, 0x1f)) goto l_0x1019_40a1; /* js 0x101940a1 */
            ii(0x1019_4082, 6); add(edi, memd[ds, Definitions.video_win_start]); /* add edi, [0x10209ca8] */
            ii(0x1019_4088, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1019_408b, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x1019_408d, 2); add(edi, eax);                          /* add edi, eax */
            ii(0x1019_408f, 2); jmp(0x1019_40f2, 0x61); goto l_0x1019_40f2; /* jmp 0x101940f2 */
        l_0x1019_4091:
            ii(0x1019_4091, 1); push(ecx);                              /* push ecx */
            ii(0x1019_4092, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_4094, 3); add(ebx, memd[ss, ebp - 0x2c]);         /* add ebx, [ebp-0x2c] */
            ii(0x1019_4097, 3); add(edx, memd[ss, ebp - 0x2c]);         /* add edx, [ebp-0x2c] */
            ii(0x1019_409a, 6); add(edi, memd[ds, Definitions.video_win_start]); /* add edi, [0x10209ca8] */
            ii(0x1019_40a0, 1); ret(); return;                          /* ret */
        l_0x1019_40a1:
            ii(0x1019_40a1, 1); push(ecx);                              /* push ecx */
            ii(0x1019_40a2, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_40a4, 2); sub(esi, edi);                          /* sub esi, edi */
            ii(0x1019_40a6, 3); sar(edi, 2);                            /* sar edi, 0x2 */
            ii(0x1019_40a9, 2); add(ecx, edi);                          /* add ecx, edi */
            ii(0x1019_40ab, 6); mov(edi, memd[ds, Definitions.video_win_start]); /* mov edi, [0x10209ca8] */
            ii(0x1019_40b1, 3); add(ebx, memd[ss, ebp - 0x2c]);         /* add ebx, [ebp-0x2c] */
            ii(0x1019_40b4, 3); add(edx, memd[ss, ebp - 0x2c]);         /* add edx, [ebp-0x2c] */
            ii(0x1019_40b7, 1); ret(); return;                          /* ret */
        //  ii(0x1019_40b8, 58); Недостижимый код.
        l_0x1019_40f2:
            ii(0x1019_40f2, 3); sub(esi, memd[ss, ebp - 0x10]);         /* sub esi, [ebp-0x10] */
            ii(0x1019_40f5, 3); sub(edi, memd[ss, ebp - 0x14]);         /* sub edi, [ebp-0x14] */
            ii(0x1019_40f8, 1); pop(edx);                               /* pop edx */
            ii(0x1019_40f9, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_40fa, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_40fb, 1); ret();                                  /* ret */
        }
    }
}
