using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d617bfd7-1ccc-4951-aca2-bbd3dba9b684")]
        public void Method_1007_6b58()
        {
            ii(0x1007_6b58, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_6b5d, 5); calld(Definitions.sys_check_available_stack_size, 0xef1f0); /* call 0x10165d52 */
            ii(0x1007_6b62, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_6b63, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_6b64, 1); pushd(edx);                             /* push edx */
            ii(0x1007_6b65, 1); pushd(esi);                             /* push esi */
            ii(0x1007_6b66, 1); pushd(edi);                             /* push edi */
            ii(0x1007_6b67, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_6b68, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_6b6a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_6b70, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_6b73, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_6b76, 3); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x1007_6b79, 5); calld(0x1007_6c68, 0xea);               /* call 0x10076c68 */
            ii(0x1007_6b7e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_6b81, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_6b84, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_6b86, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_6b87, 1); popd(edi);                              /* pop edi */
            ii(0x1007_6b88, 1); popd(esi);                              /* pop esi */
            ii(0x1007_6b89, 1); popd(edx);                              /* pop edx */
            ii(0x1007_6b8a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_6b8b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_6b8c, 1); retd(); return;                         /* ret */
        }
    }
}