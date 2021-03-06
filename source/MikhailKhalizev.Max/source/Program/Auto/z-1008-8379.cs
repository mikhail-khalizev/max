using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_8379-1c5c26e4")]
        public void Method_1008_8379()
        {
            ii(0x1008_8379, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1008_837e, 5);  call(Definitions.sys_check_available_stack_size, 0xd_d9cf);/* call 0x10165d52 */
            ii(0x1008_8383, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_8384, 1);  push(esi);                            /* push esi */
            ii(0x1008_8385, 1);  push(edi);                            /* push edi */
            ii(0x1008_8386, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_8387, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_8389, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1008_838f, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1008_8392, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1008_8395, 3);  mov(memb[ss, ebp - 4], bl);           /* mov [ebp-0x4], bl */
            ii(0x1008_8398, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_839b, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_839e, 4);  cmp(memb[ss, ebp - 4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1008_83a2, 2);  if(jnz(0x1008_83b8, 0x14)) goto l_0x1008_83b8;/* jnz 0x100883b8 */
            ii(0x1008_83a4, 5);  mov(ebx, 0x1008_8379);                /* mov ebx, 0x10088379 */
            ii(0x1008_83a9, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1008_83ac, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_83af, 5);  call(0x1007_8d4a, -0xf66a);           /* call 0x10078d4a */
            ii(0x1008_83b4, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_83b6, 2);  if(jnz(0x1008_83d2, 0x1a)) goto l_0x1008_83d2;/* jnz 0x100883d2 */
        l_0x1008_83b8:
            ii(0x1008_83b8, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1008_83bb, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_83be, 5);  call(0x1015_2a52, 0xc_a68f);          /* call 0x10152a52 */
            ii(0x1008_83c3, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_83c5, 2);  if(jz(0x1008_83d2, 0xb)) goto l_0x1008_83d2;/* jz 0x100883d2 */
            ii(0x1008_83c7, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_83ca, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_83cd, 5);  call(0x1008_84ce, 0xfc);              /* call 0x100884ce */
        l_0x1008_83d2:
            ii(0x1008_83d2, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_83d4, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_83d5, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_83d6, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_83d7, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_83d8, 1);  ret();                                /* ret */
        }
    }
}
