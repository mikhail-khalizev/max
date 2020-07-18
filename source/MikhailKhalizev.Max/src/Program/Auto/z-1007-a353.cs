using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_a353-a875c9b7")]
        public void Method_1007_a353()
        {
            ii(0x1007_a353, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1007_a358, 5);  call(Definitions.sys_check_available_stack_size, 0xe_b9f5);/* call 0x10165d52 */
            ii(0x1007_a35d, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_a35e, 1);  push(esi);                            /* push esi */
            ii(0x1007_a35f, 1);  push(edi);                            /* push edi */
            ii(0x1007_a360, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_a361, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_a363, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1007_a369, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1007_a36c, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1007_a36f, 3);  mov(memb[ss, ebp - 4], bl);           /* mov [ebp-0x4], bl */
            ii(0x1007_a372, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1007_a375, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_a378, 4);  cmp(memb[ss, ebp - 4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1007_a37c, 2);  if(jnz(0x1007_a392, 0x14)) goto l_0x1007_a392;/* jnz 0x1007a392 */
            ii(0x1007_a37e, 5);  mov(ebx, 0x1007_a353);                /* mov ebx, 0x1007a353 */
            ii(0x1007_a383, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1007_a386, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_a389, 5);  call(0x1007_8d4a, -0x1644);           /* call 0x10078d4a */
            ii(0x1007_a38e, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_a390, 2);  if(jnz(0x1007_a3ac, 0x1a)) goto l_0x1007_a3ac;/* jnz 0x1007a3ac */
        l_0x1007_a392:
            ii(0x1007_a392, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1007_a395, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_a398, 5);  call(0x1015_2a52, 0xd_86b5);          /* call 0x10152a52 */
            ii(0x1007_a39d, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_a39f, 2);  if(jz(0x1007_a3ac, 0xb)) goto l_0x1007_a3ac;/* jz 0x1007a3ac */
            ii(0x1007_a3a1, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1007_a3a4, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_a3a7, 5);  call(0x1007_aa70, 0x6c4);             /* call 0x1007aa70 */
        l_0x1007_a3ac:
            ii(0x1007_a3ac, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_a3ae, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_a3af, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_a3b0, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_a3b1, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_a3b2, 1);  ret();                                /* ret */
        }
    }
}
