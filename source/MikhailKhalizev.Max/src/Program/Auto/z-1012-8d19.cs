using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("304284a7-0dca-4054-a944-72bfb0d9d60f")]
        public void Method_1012_8d19()
        {
            ii(0x1012_8d19, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1012_8d1e, 5); calld(Definitions.sys_check_available_stack_size, 0x3_d02f); /* call 0x10165d52 */
            ii(0x1012_8d23, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_8d24, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_8d25, 1); pushd(edx);                             /* push edx */
            ii(0x1012_8d26, 1); pushd(esi);                             /* push esi */
            ii(0x1012_8d27, 1); pushd(edi);                             /* push edi */
            ii(0x1012_8d28, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_8d29, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_8d2b, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1012_8d31, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_8d34, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x1012_8d3b, 2); if(jzd(0x1012_8d6f, 0x32)) goto l_0x1012_8d6f; /* jz 0x10128d6f */
            ii(0x1012_8d3d, 7); mov(memb_a32[ds, 0x101c_5c1c], 0x16);   /* mov byte [0x101c5c1c], 0x16 */
            ii(0x1012_8d44, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_8d47, 5); calld(0x1007_6154, -0xb_2bf8);          /* call 0x10076154 */
            ii(0x1012_8d4c, 6); mov(memw_a32[ds, 0x101c_5c1d], ax);     /* mov [0x101c5c1d], ax */
            ii(0x1012_8d52, 5); mov(edx, 0x101c_5c21);                  /* mov edx, 0x101c5c21 */
            ii(0x1012_8d57, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_8d5a, 5); calld(0x1015_1e55, 0x2_90f6);           /* call 0x10151e55 */
            ii(0x1012_8d5f, 6); mov(memw_a32[ds, 0x101c_5c1f], ax);     /* mov [0x101c5c1f], ax */
            ii(0x1012_8d65, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1012_8d6a, 5); calld(0x1012_5be9, -0x3186);            /* call 0x10125be9 */
        l_0x1012_8d6f:
            ii(0x1012_8d6f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_8d71, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_8d72, 1); popd(edi);                              /* pop edi */
            ii(0x1012_8d73, 1); popd(esi);                              /* pop esi */
            ii(0x1012_8d74, 1); popd(edx);                              /* pop edx */
            ii(0x1012_8d75, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_8d76, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_8d77, 1); retd(); return;                         /* ret */
        }
    }
}
