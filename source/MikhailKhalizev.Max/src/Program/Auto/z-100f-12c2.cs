using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8c0e109b-a5d7-47ef-993e-3afe84d0b9a5")]
        public void Method_100f_12c2()
        {
            ii(0x100f_12c2, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100f_12c7, 5); calld(Definitions.sys_check_available_stack_size, 0x7_4a86); /* call 0x10165d52 */
            ii(0x100f_12cc, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_12cd, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_12ce, 1); pushd(edx);                             /* push edx */
            ii(0x100f_12cf, 1); pushd(esi);                             /* push esi */
            ii(0x100f_12d0, 1); pushd(edi);                             /* push edi */
            ii(0x100f_12d1, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_12d2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_12d4, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100f_12da, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_12dd, 5); mov(eax, 0x39);                         /* mov eax, 0x39 */
            ii(0x100f_12e2, 5); calld(0x100e_883d, -0x8aaa);            /* call 0x100e883d */
            ii(0x100f_12e7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_12e9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_12ec, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x100f_12ee, 5); mov(eax, 0x3a);                         /* mov eax, 0x3a */
            ii(0x100f_12f3, 5); calld(0x100e_883d, -0x8abb);            /* call 0x100e883d */
            ii(0x100f_12f8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_12fa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_12fd, 3); mov(memd_a32[ds, eax + 0x4], edx);      /* mov [eax+0x4], edx */
            ii(0x100f_1300, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_1303, 7); mov(memd_a32[ds, eax + 0x8], 0);        /* mov dword [eax+0x8], 0x0 */
            ii(0x100f_130a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_130d, 7); mov(memd_a32[ds, eax + 0xc], 0);        /* mov dword [eax+0xc], 0x0 */
            ii(0x100f_1314, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_1317, 7); mov(memd_a32[ds, eax + 0x10], 0);       /* mov dword [eax+0x10], 0x0 */
            ii(0x100f_131e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_1321, 7); mov(memd_a32[ds, eax + 0x14], 0);       /* mov dword [eax+0x14], 0x0 */
            ii(0x100f_1328, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_132b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100f_132e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_1331, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_1333, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_1334, 1); popd(edi);                              /* pop edi */
            ii(0x100f_1335, 1); popd(esi);                              /* pop esi */
            ii(0x100f_1336, 1); popd(edx);                              /* pop edx */
            ii(0x100f_1337, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_1338, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_1339, 1); retd(); return;                         /* ret */
        }
    }
}