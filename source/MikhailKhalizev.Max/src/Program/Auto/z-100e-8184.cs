using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_8184-184a4e0b")]
        public void Method_100e_8184()
        {
            ii(0x100e_8184, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100e_8189, 5);  call(Definitions.sys_check_available_stack_size, 0x7_dbc4);/* call 0x10165d52 */
            ii(0x100e_818e, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_818f, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_8190, 1);  push(esi);                            /* push esi */
            ii(0x100e_8191, 1);  push(edi);                            /* push edi */
            ii(0x100e_8192, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_8193, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_8195, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100e_819b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_819e, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_81a1, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_81a3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_81a6, 5);  add(eax, 0x8e);                       /* add eax, 0x8e */
            ii(0x100e_81ab, 5);  call(0x100e_8144, -0x6c);             /* call 0x100e8144 */
            ii(0x100e_81b0, 5);  sub(eax, 0x8e);                       /* sub eax, 0x8e */
            ii(0x100e_81b5, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_81b8, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_81ba, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_81bd, 5);  add(eax, 0x84);                       /* add eax, 0x84 */
            ii(0x100e_81c2, 5);  call(0x100e_8144, -0x83);             /* call 0x100e8144 */
            ii(0x100e_81c7, 5);  sub(eax, 0x84);                       /* sub eax, 0x84 */
            ii(0x100e_81cc, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_81cf, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_81d1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_81d4, 3);  add(eax, 0x7a);                       /* add eax, 0x7a */
            ii(0x100e_81d7, 5);  call(0x100e_8144, -0x98);             /* call 0x100e8144 */
            ii(0x100e_81dc, 3);  sub(eax, 0x7a);                       /* sub eax, 0x7a */
            ii(0x100e_81df, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_81e2, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_81e4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_81e7, 3);  add(eax, 0x70);                       /* add eax, 0x70 */
            ii(0x100e_81ea, 5);  call(0x100e_8144, -0xab);             /* call 0x100e8144 */
            ii(0x100e_81ef, 3);  sub(eax, 0x70);                       /* sub eax, 0x70 */
            ii(0x100e_81f2, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_81f5, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_81f7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_81fa, 3);  add(eax, 0x66);                       /* add eax, 0x66 */
            ii(0x100e_81fd, 5);  call(0x100e_8144, -0xbe);             /* call 0x100e8144 */
            ii(0x100e_8202, 3);  sub(eax, 0x66);                       /* sub eax, 0x66 */
            ii(0x100e_8205, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_8208, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_820a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_820d, 3);  add(eax, 0x5c);                       /* add eax, 0x5c */
            ii(0x100e_8210, 5);  call(0x100e_8144, -0xd1);             /* call 0x100e8144 */
            ii(0x100e_8215, 3);  sub(eax, 0x5c);                       /* sub eax, 0x5c */
            ii(0x100e_8218, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_821b, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_821d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_8220, 3);  add(eax, 0x52);                       /* add eax, 0x52 */
            ii(0x100e_8223, 5);  call(0x100e_8144, -0xe4);             /* call 0x100e8144 */
            ii(0x100e_8228, 3);  sub(eax, 0x52);                       /* sub eax, 0x52 */
            ii(0x100e_822b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_822e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_8230, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_8233, 3);  add(eax, 0x48);                       /* add eax, 0x48 */
            ii(0x100e_8236, 5);  call(0x100e_8144, -0xf7);             /* call 0x100e8144 */
            ii(0x100e_823b, 3);  sub(eax, 0x48);                       /* sub eax, 0x48 */
            ii(0x100e_823e, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_8241, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_8243, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_8246, 3);  add(eax, 0x3e);                       /* add eax, 0x3e */
            ii(0x100e_8249, 5);  call(0x100e_8144, -0x10a);            /* call 0x100e8144 */
            ii(0x100e_824e, 3);  sub(eax, 0x3e);                       /* sub eax, 0x3e */
            ii(0x100e_8251, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_8254, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_8256, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_8259, 3);  add(eax, 0x34);                       /* add eax, 0x34 */
            ii(0x100e_825c, 5);  call(0x100e_8144, -0x11d);            /* call 0x100e8144 */
            ii(0x100e_8261, 3);  sub(eax, 0x34);                       /* sub eax, 0x34 */
            ii(0x100e_8264, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_8267, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_8269, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_826c, 3);  add(eax, 0x2a);                       /* add eax, 0x2a */
            ii(0x100e_826f, 5);  call(0x100e_8144, -0x130);            /* call 0x100e8144 */
            ii(0x100e_8274, 3);  sub(eax, 0x2a);                       /* sub eax, 0x2a */
            ii(0x100e_8277, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_827a, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_827c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_827f, 3);  add(eax, 0x20);                       /* add eax, 0x20 */
            ii(0x100e_8282, 5);  call(0x100e_8144, -0x143);            /* call 0x100e8144 */
            ii(0x100e_8287, 3);  sub(eax, 0x20);                       /* sub eax, 0x20 */
            ii(0x100e_828a, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_828d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_8290, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100e_8293, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100e_8296, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_8298, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_8299, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_829a, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_829b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_829c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_829d, 1);  ret();                                /* ret */
        }
    }
}
