using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_8564-540ea8c5")]
        public void Method_100e_8564()
        {
            ii(0x100e_8564, 5); push(0x28);                             /* push 0x28 */
            ii(0x100e_8569, 5); call(Definitions.sys_check_available_stack_size, 0x7_d7e4); /* call 0x10165d52 */
            ii(0x100e_856e, 1); push(ebx);                              /* push ebx */
            ii(0x100e_856f, 1); push(ecx);                              /* push ecx */
            ii(0x100e_8570, 1); push(esi);                              /* push esi */
            ii(0x100e_8571, 1); push(edi);                              /* push edi */
            ii(0x100e_8572, 1); push(ebp);                              /* push ebp */
            ii(0x100e_8573, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_8575, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100e_857b, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_857e, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_8581, 5); mov(ebx, 0x10);                         /* mov ebx, 0x10 */
            ii(0x100e_8586, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100e_858a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_858d, 5); call(0x100c_d7e8, -0x1_adaa);           /* call 0x100cd7e8 */
            ii(0x100e_8592, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_8595, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100e_8598, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100e_859b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_859e, 7); mov(memd[ds, eax + 0xc], 0x101b_6104);  /* mov dword [eax+0xc], 0x101b6104 */
            ii(0x100e_85a5, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_85a8, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100e_85ab, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_85ae, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_85b0, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_85b1, 1); pop(edi);                               /* pop edi */
            ii(0x100e_85b2, 1); pop(esi);                               /* pop esi */
            ii(0x100e_85b3, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_85b4, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_85b5, 1); ret();                                  /* ret */
        }
    }
}
