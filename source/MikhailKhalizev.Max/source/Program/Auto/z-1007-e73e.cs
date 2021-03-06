using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_e73e-1cdadced")]
        public void Method_1007_e73e()
        {
            ii(0x1007_e73e, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1007_e743, 5);  call(Definitions.sys_check_available_stack_size, 0xe_760a);/* call 0x10165d52 */
            ii(0x1007_e748, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_e749, 1);  push(esi);                            /* push esi */
            ii(0x1007_e74a, 1);  push(edi);                            /* push edi */
            ii(0x1007_e74b, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_e74c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_e74e, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1007_e754, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1007_e757, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1007_e75a, 3);  mov(memb[ss, ebp - 4], bl);           /* mov [ebp-0x4], bl */
            ii(0x1007_e75d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1007_e760, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_e763, 4);  cmp(memb[ss, ebp - 4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1007_e767, 2);  if(jnz(0x1007_e77d, 0x14)) goto l_0x1007_e77d;/* jnz 0x1007e77d */
            ii(0x1007_e769, 5);  mov(ebx, 0x1007_e73e);                /* mov ebx, 0x1007e73e */
            ii(0x1007_e76e, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1007_e771, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_e774, 5);  call(0x1007_8d4a, -0x5a2f);           /* call 0x10078d4a */
            ii(0x1007_e779, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_e77b, 2);  if(jnz(0x1007_e797, 0x1a)) goto l_0x1007_e797;/* jnz 0x1007e797 */
        l_0x1007_e77d:
            ii(0x1007_e77d, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1007_e780, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_e783, 5);  call(0x1015_2a52, 0xd_42ca);          /* call 0x10152a52 */
            ii(0x1007_e788, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_e78a, 2);  if(jz(0x1007_e797, 0xb)) goto l_0x1007_e797;/* jz 0x1007e797 */
            ii(0x1007_e78c, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1007_e78f, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_e792, 5);  call(0x1007_e812, 0x7b);              /* call 0x1007e812 */
        l_0x1007_e797:
            ii(0x1007_e797, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_e799, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_e79a, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_e79b, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_e79c, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_e79d, 1);  ret();                                /* ret */
        }
    }
}
