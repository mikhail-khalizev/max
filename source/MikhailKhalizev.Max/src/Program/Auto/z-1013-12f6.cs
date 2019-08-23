using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_12f6-8c38a951")]
        public void Method_1013_12f6()
        {
            ii(0x1013_12f6, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_12fb, 5); calld(Definitions.sys_check_available_stack_size, 0x3_4a52); /* call 0x10165d52 */
            ii(0x1013_1300, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_1301, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_1302, 1); pushd(esi);                             /* push esi */
            ii(0x1013_1303, 1); pushd(edi);                             /* push edi */
            ii(0x1013_1304, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_1305, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_1307, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_130d, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_1310, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_1313, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_1316, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_1319, 7); mov(memb_a32[ds, 0x101c_61b3], 0x1);    /* mov byte [0x101c61b3], 0x1 */
            ii(0x1013_1320, 7); mov(memb_a32[ds, 0x101c_61b0], 0);      /* mov byte [0x101c61b0], 0x0 */
            ii(0x1013_1327, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_1329, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_132c, 6); mov(eax, memd_a32[ds, eax + 0xbe]);     /* mov eax, [eax+0xbe] */
            ii(0x1013_1332, 5); calld(0x100c_fb73, -0x6_17c4);          /* call 0x100cfb73 */
            ii(0x1013_1337, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_133a, 5); calld(0x1012_f003, -0x233c);            /* call 0x1012f003 */
            ii(0x1013_133f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_1342, 4); cmp(memb_a32[ds, eax + 0x17], 0);       /* cmp byte [eax+0x17], 0x0 */
            ii(0x1013_1346, 2); if(jzd(0x1013_1351, 0x9)) goto l_0x1013_1351; /* jz 0x10131351 */
            ii(0x1013_1348, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_134b, 4); cmp(memb_a32[ds, eax + 0x17], 0x1);     /* cmp byte [eax+0x17], 0x1 */
            ii(0x1013_134f, 2); if(jnzd(0x1013_135e, 0xd)) goto l_0x1013_135e; /* jnz 0x1013135e */
        l_0x1013_1351:
            ii(0x1013_1351, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_1356, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_1359, 5); calld(0x1013_0c16, -0x748);             /* call 0x10130c16 */
        l_0x1013_135e:
            ii(0x1013_135e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_1360, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_1361, 1); popd(edi);                              /* pop edi */
            ii(0x1013_1362, 1); popd(esi);                              /* pop esi */
            ii(0x1013_1363, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_1364, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_1365, 1); retd();                                 /* ret */
        }
    }
}
