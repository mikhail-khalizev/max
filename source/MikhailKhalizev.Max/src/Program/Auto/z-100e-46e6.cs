using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_46e6-5dc72e2d")]
        public void Method_100e_46e6()
        {
            ii(0x100e_46e6, 5); push(0x48);                             /* push 0x48 */
            ii(0x100e_46eb, 5); call(Definitions.sys_check_available_stack_size, 0x8_1662); /* call 0x10165d52 */
            ii(0x100e_46f0, 1); push(ebx);                              /* push ebx */
            ii(0x100e_46f1, 1); push(ecx);                              /* push ecx */
            ii(0x100e_46f2, 1); push(esi);                              /* push esi */
            ii(0x100e_46f3, 1); push(edi);                              /* push edi */
            ii(0x100e_46f4, 1); push(ebp);                              /* push ebp */
            ii(0x100e_46f5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_46f7, 6); sub(esp, 0x30);                         /* sub esp, 0x30 */
            ii(0x100e_46fd, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100e_4700, 3); mov(memd[ss, ebp - 16], edx);           /* mov [ebp-0x10], edx */
            ii(0x100e_4703, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100e_4706, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_4709, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100e_470c, 6); add(memd[ds, 0x101b_7f10], eax);        /* add [0x101b7f10], eax */
            ii(0x100e_4712, 5); mov(ebx, 0x1c);                         /* mov ebx, 0x1c */
            ii(0x100e_4717, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_4719, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x100e_471c, 5); call(Definitions.sys_memset, 0x8_16bf); /* call 0x10165de0 */
            ii(0x100e_4721, 6); mov(memw[ss, ebp - 44], 0x600);         /* mov word [ebp-0x2c], 0x600 */
            ii(0x100e_4727, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_472a, 3); shr(eax, 0x10);                         /* shr eax, 0x10 */
            ii(0x100e_472d, 4); mov(memw[ss, ebp - 40], ax);            /* mov [ebp-0x28], ax */
            ii(0x100e_4731, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_4734, 4); mov(memw[ss, ebp - 36], ax);            /* mov [ebp-0x24], ax */
            ii(0x100e_4738, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100e_473b, 3); shr(eax, 0x10);                         /* shr eax, 0x10 */
            ii(0x100e_473e, 4); mov(memw[ss, ebp - 28], ax);            /* mov [ebp-0x1c], ax */
            ii(0x100e_4742, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100e_4745, 4); mov(memw[ss, ebp - 24], ax);            /* mov [ebp-0x18], ax */
            ii(0x100e_4749, 3); lea(ebx, memd[ss, ebp - 44]);           /* lea ebx, [ebp-0x2c] */
            ii(0x100e_474c, 3); lea(edx, memd[ss, ebp - 44]);           /* lea edx, [ebp-0x2c] */
            ii(0x100e_474f, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x100e_4754, 5); call(/* sys */ 0x1016_c606, 0x8_7ead);  /* call 0x1016c606 */
            ii(0x100e_4759, 4); cmp(memd[ss, ebp - 20], 0);             /* cmp dword [ebp-0x14], 0x0 */
            ii(0x100e_475d, 2); if(jnz(0x100e_4768, 9)) goto l_0x100e_4768; /* jnz 0x100e4768 */
            ii(0x100e_475f, 7); mov(memd[ss, ebp - 48], 1);             /* mov dword [ebp-0x30], 0x1 */
            ii(0x100e_4766, 2); jmp(0x100e_476f, 7); goto l_0x100e_476f; /* jmp 0x100e476f */
        l_0x100e_4768:
            ii(0x100e_4768, 7); mov(memd[ss, ebp - 48], 0);             /* mov dword [ebp-0x30], 0x0 */
        l_0x100e_476f:
            ii(0x100e_476f, 3); mov(eax, memd[ss, ebp - 48]);           /* mov eax, [ebp-0x30] */
            ii(0x100e_4772, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_4775, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_4778, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_477a, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_477b, 1); pop(edi);                               /* pop edi */
            ii(0x100e_477c, 1); pop(esi);                               /* pop esi */
            ii(0x100e_477d, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_477e, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_477f, 1); ret();                                  /* ret */
        }
    }
}
