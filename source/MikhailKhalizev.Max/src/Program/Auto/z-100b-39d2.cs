using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("57fd0bf5-445b-4ba4-a97f-1a515f2b1ee9")]
        public void Method_100b_39d2()
        {
            ii(0x100b_39d2, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_39d7, 5); calld(Definitions.sys_check_available_stack_size, 0xb_2376); /* call 0x10165d52 */
            ii(0x100b_39dc, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_39dd, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_39de, 1); pushd(esi);                             /* push esi */
            ii(0x100b_39df, 1); pushd(edi);                             /* push edi */
            ii(0x100b_39e0, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_39e1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_39e3, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_39e9, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_39ec, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_39ef, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100b_39f2, 3); add(edx, 0x13);                         /* add edx, 0x13 */
            ii(0x100b_39f5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_39f8, 5); calld(0x1008_b4b4, -0x2_8549);          /* call 0x1008b4b4 */
            ii(0x100b_39fd, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x100b_3a00, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100b_3a03, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_3a05, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_3a06, 1); popd(edi);                              /* pop edi */
            ii(0x100b_3a07, 1); popd(esi);                              /* pop esi */
            ii(0x100b_3a08, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_3a09, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_3a0a, 1); retd(); return;                         /* ret */
        }
    }
}
