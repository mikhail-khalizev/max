using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("46cfa85c-988c-406f-9a64-47bccf9403f9")]
        public void Method_1007_62cc()
        {
            ii(0x1007_62cc, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_62d1, 5); calld(Definitions.sys_check_available_stack_size, 0xe_fa7c); /* call 0x10165d52 */
            ii(0x1007_62d6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_62d7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_62d8, 1); pushd(esi);                             /* push esi */
            ii(0x1007_62d9, 1); pushd(edi);                             /* push edi */
            ii(0x1007_62da, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_62db, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_62dd, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_62e3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_62e6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_62e9, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_62ec, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_62ef, 5); calld(0x1013_a21a, 0xc_3f26);           /* call 0x1013a21a */
            ii(0x1007_62f4, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_62f7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_62fa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_62fc, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_62fd, 1); popd(edi);                              /* pop edi */
            ii(0x1007_62fe, 1); popd(esi);                              /* pop esi */
            ii(0x1007_62ff, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_6300, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_6301, 1); retd(); return;                         /* ret */
        }
    }
}
