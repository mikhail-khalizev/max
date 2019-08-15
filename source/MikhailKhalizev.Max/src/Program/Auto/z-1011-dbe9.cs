using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("afd7a65d-6ddd-4902-9927-3dafe6655518")]
        public void Method_1011_dbe9()
        {
            ii(0x1011_dbe9, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1011_dbee, 5); calld(Definitions.sys_check_available_stack_size, 0x4_815f); /* call 0x10165d52 */
            ii(0x1011_dbf3, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_dbf4, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_dbf5, 1); pushd(edx);                             /* push edx */
            ii(0x1011_dbf6, 1); pushd(esi);                             /* push esi */
            ii(0x1011_dbf7, 1); pushd(edi);                             /* push edi */
            ii(0x1011_dbf8, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_dbf9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_dbfb, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1011_dc01, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_dc04, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_dc07, 5); calld(0x100b_7fdc, -0x6_5c30);          /* call 0x100b7fdc */
            ii(0x1011_dc0c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_dc0f, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1011_dc12, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_dc15, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_dc18, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1011_dc1b, 5); calld(0x1012_08c8, 0x2ca8);             /* call 0x101208c8 */
            ii(0x1011_dc20, 3); sub(eax, 0x4);                          /* sub eax, 0x4 */
            ii(0x1011_dc23, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_dc26, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1011_dc29, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_dc2c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_dc2f, 7); mov(memd_a32[ds, eax + 0x16], 0);       /* mov dword [eax+0x16], 0x0 */
            ii(0x1011_dc36, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_dc39, 7); mov(memd_a32[ds, eax + 0x1a], 0);       /* mov dword [eax+0x1a], 0x0 */
            ii(0x1011_dc40, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_dc43, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_dc46, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_dc49, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_dc4b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_dc4c, 1); popd(edi);                              /* pop edi */
            ii(0x1011_dc4d, 1); popd(esi);                              /* pop esi */
            ii(0x1011_dc4e, 1); popd(edx);                              /* pop edx */
            ii(0x1011_dc4f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_dc50, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_dc51, 1); retd(); return;                         /* ret */
        }
    }
}
