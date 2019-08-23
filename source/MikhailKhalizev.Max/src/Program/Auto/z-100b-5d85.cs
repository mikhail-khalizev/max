using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_5d85-dfe75ac9")]
        public void Method_100b_5d85()
        {
            ii(0x100b_5d85, 5); push(0x2c);                             /* push 0x2c */
            ii(0x100b_5d8a, 5); call(Definitions.sys_check_available_stack_size, 0xa_ffc3); /* call 0x10165d52 */
            ii(0x100b_5d8f, 1); push(ebx);                              /* push ebx */
            ii(0x100b_5d90, 1); push(ecx);                              /* push ecx */
            ii(0x100b_5d91, 1); push(esi);                              /* push esi */
            ii(0x100b_5d92, 1); push(edi);                              /* push edi */
            ii(0x100b_5d93, 1); push(ebp);                              /* push ebp */
            ii(0x100b_5d94, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_5d96, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100b_5d9c, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_5d9f, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100b_5da2, 5); mov(ecx, 0x2800);                       /* mov ecx, 0x2800 */
            ii(0x100b_5da7, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_5da9, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100b_5dad, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_5db0, 5); call(0x100a_26d1, -0x1_36e4);           /* call 0x100a26d1 */
            ii(0x100b_5db5, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_5db8, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x100b_5dbb, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100b_5dbe, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_5dc1, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_5dc4, 5); call(Definitions.my_ctor_0x101b_56fc, -0x2_d14d); /* call 0x10088c7c */
            ii(0x100b_5dc9, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x100b_5dcc, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_5dcf, 3); lea(eax, memd[ss, ebp - 0x8]);          /* lea eax, [ebp-0x8] */
            ii(0x100b_5dd2, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100b_5dd5, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_5dd8, 7); mov(memd[ds, eax + 0x2], 0x101b_5184);  /* mov dword [eax+0x2], 0x101b5184 */
            ii(0x100b_5ddf, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_5de2, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100b_5de5, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100b_5de8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_5dea, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_5deb, 1); pop(edi);                               /* pop edi */
            ii(0x100b_5dec, 1); pop(esi);                               /* pop esi */
            ii(0x100b_5ded, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_5dee, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_5def, 1); ret();                                  /* ret */
        }
    }
}
