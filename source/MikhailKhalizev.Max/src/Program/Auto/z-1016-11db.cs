using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_11db-f698ed2a")]
        public void Method_1016_11db()
        {
            ii(0x1016_11db, 5); push(0x24);                             /* push 0x24 */
            ii(0x1016_11e0, 5); call(Definitions.sys_check_available_stack_size, 0x4b6d); /* call 0x10165d52 */
            ii(0x1016_11e5, 1); push(ebx);                              /* push ebx */
            ii(0x1016_11e6, 1); push(ecx);                              /* push ecx */
            ii(0x1016_11e7, 1); push(edx);                              /* push edx */
            ii(0x1016_11e8, 1); push(esi);                              /* push esi */
            ii(0x1016_11e9, 1); push(edi);                              /* push edi */
            ii(0x1016_11ea, 1); push(ebp);                              /* push ebp */
            ii(0x1016_11eb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_11ed, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1016_11f3, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1016_11f6, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_11f9, 5); call(0x1012_0a5c, -0x4_07a2);           /* call 0x10120a5c */
            ii(0x1016_11fe, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_1200, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_1203, 4); cmp(dx, memw[ds, eax + 0x3b]);          /* cmp dx, [eax+0x3b] */
            ii(0x1016_1207, 2); if(jnz(0x1016_1216, 0xd)) goto l_0x1016_1216; /* jnz 0x10161216 */
            ii(0x1016_1209, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_120c, 5); call(0x1015_f2cc, -0x1f45);             /* call 0x1015f2cc */
            ii(0x1016_1211, 5); jmp(0x1016_12c7, 0xb1); goto l_0x1016_12c7; /* jmp 0x101612c7 */
        l_0x1016_1216:
            ii(0x1016_1216, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_1219, 5); call(0x1007_611c, -0xe_b102);           /* call 0x1007611c */
            ii(0x1016_121e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_1220, 2); if(jz(0x1016_123c, 0x1a)) goto l_0x1016_123c; /* jz 0x1016123c */
            ii(0x1016_1222, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_1225, 3); mov(eax, memd[ds, eax + 0x39]);         /* mov eax, [eax+0x39] */
            ii(0x1016_1228, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_122b, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1016_122d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_122f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_1232, 5); call(0x1012_0a5c, -0x4_07db);           /* call 0x10120a5c */
            ii(0x1016_1237, 1); cwde();                                 /* cwde */
            ii(0x1016_1238, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1016_123a, 2); if(jz(0x1016_123e, 0x2)) goto l_0x1016_123e; /* jz 0x1016123e */
        l_0x1016_123c:
            ii(0x1016_123c, 2); jmp(0x1016_129c, 0x5e); goto l_0x1016_129c; /* jmp 0x1016129c */
        l_0x1016_123e:
            ii(0x1016_123e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_1241, 5); call(0x1007_611c, -0xe_b12a);           /* call 0x1007611c */
            ii(0x1016_1246, 3); lea(ebx, ebp - 0x8);                    /* lea ebx, [ebp-0x8] */
            ii(0x1016_1249, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_124b, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_124d, 5); call(0x1007_66ac, -0xe_aba6);           /* call 0x100766ac */
            ii(0x1016_1252, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_1254, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_1257, 5); call(0x1008_a998, -0xd_68c4);           /* call 0x1008a998 */
            ii(0x1016_125c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_125e, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1016_1261, 5); call(0x1013_ad71, -0x2_64f5);           /* call 0x1013ad71 */
            ii(0x1016_1266, 2); test(al, al);                           /* test al, al */
            ii(0x1016_1268, 2); if(jz(0x1016_127e, 0x14)) goto l_0x1016_127e; /* jz 0x1016127e */
            ii(0x1016_126a, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1016_126d, 5); call(0x1007_6574, -0xe_acfe);           /* call 0x10076574 */
            ii(0x1016_1272, 3); mov(al, memb[ds, eax + 0x4d]);          /* mov al, [eax+0x4d] */
            ii(0x1016_1275, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_127a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_127c, 2); if(jz(0x1016_1280, 0x2)) goto l_0x1016_1280; /* jz 0x10161280 */
        l_0x1016_127e:
            ii(0x1016_127e, 2); jmp(0x1016_1292, 0x12); goto l_0x1016_1292; /* jmp 0x10161292 */
        l_0x1016_1280:
            ii(0x1016_1280, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1016_1285, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1016_1288, 5); call(0x1007_65d0, -0xe_acbd);           /* call 0x100765d0 */
            ii(0x1016_128d, 5); call(0x1016_07bf, -0xad3);              /* call 0x101607bf */
        l_0x1016_1292:
            ii(0x1016_1292, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_1294, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1016_1297, 5); call(0x1007_5f2c, -0xe_b370);           /* call 0x10075f2c */
        l_0x1016_129c:
            ii(0x1016_129c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_129f, 4); test(memb[ds, eax + 0x5e], 0x1);        /* test byte [eax+0x5e], 0x1 */
            ii(0x1016_12a3, 2); if(jz(0x1016_12b9, 0x14)) goto l_0x1016_12b9; /* jz 0x101612b9 */
            ii(0x1016_12a5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_12a8, 5); call(0x1012_0a5c, -0x4_0851);           /* call 0x10120a5c */
            ii(0x1016_12ad, 1); inc(eax);                               /* inc eax */
            ii(0x1016_12ae, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1016_12b1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_12b4, 5); call(0x1014_9b07, -0x1_77b2);           /* call 0x10149b07 */
        l_0x1016_12b9:
            ii(0x1016_12b9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_12bc, 3); inc(memb[ds, eax + 0x5e]);              /* inc byte [eax+0x5e] */
            ii(0x1016_12bf, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_12c2, 5); call(0x1014_9fa8, -0x1_731f);           /* call 0x10149fa8 */
        l_0x1016_12c7:
            ii(0x1016_12c7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_12c9, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_12ca, 1); pop(edi);                               /* pop edi */
            ii(0x1016_12cb, 1); pop(esi);                               /* pop esi */
            ii(0x1016_12cc, 1); pop(edx);                               /* pop edx */
            ii(0x1016_12cd, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_12ce, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_12cf, 1); ret();                                  /* ret */
        }
    }
}
