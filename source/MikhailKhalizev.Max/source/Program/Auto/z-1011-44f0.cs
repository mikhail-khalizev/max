using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_44f0-d8180279")]
        public void Method_1011_44f0()
        {
            ii(0x1011_44f0, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1011_44f5, 5);  call(Definitions.sys_check_available_stack_size, 0x5_1858);/* call 0x10165d52 */
            ii(0x1011_44fa, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_44fb, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_44fc, 1);  push(edx);                            /* push edx */
            ii(0x1011_44fd, 1);  push(esi);                            /* push esi */
            ii(0x1011_44fe, 1);  push(edi);                            /* push edi */
            ii(0x1011_44ff, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_4500, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_4502, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1011_4508, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_450b, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_450e, 6);  add(edx, 0x21a);                      /* add edx, 0x21a */
            ii(0x1011_4514, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_4517, 5);  add(eax, 0x1a2);                      /* add eax, 0x1a2 */
            ii(0x1011_451c, 5);  call(Definitions.sys_strcpy, 0x5_19ae);/* call 0x10165ecf */
            ii(0x1011_4521, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_4524, 6);  mov(edx, memd[ds, eax + 406]);        /* mov edx, [eax+0x196] */
            ii(0x1011_452a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_452d, 6);  mov(memd[ds, eax + 414], edx);        /* mov [eax+0x19e], edx */
            ii(0x1011_4533, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_4536, 6);  add(edx, 0x1a2);                      /* add edx, 0x1a2 */
            ii(0x1011_453c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_453f, 6);  mov(eax, memd[ds, eax + 414]);        /* mov eax, [eax+0x19e] */
            ii(0x1011_4545, 5);  call(0x100e_b14d, -0x2_93fd);         /* call 0x100eb14d */
            ii(0x1011_454a, 5);  call(0x100d_6104, -0x3_e44b);         /* call 0x100d6104 */
            ii(0x1011_454f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_4551, 2);  mov(dl, al);                          /* mov dl, al */
            ii(0x1011_4553, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_4556, 6);  mov(eax, memd[ds, eax + 414]);        /* mov eax, [eax+0x19e] */
            ii(0x1011_455c, 5);  call(0x100e_b5e1, -0x2_8f80);         /* call 0x100eb5e1 */
            ii(0x1011_4561, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_4564, 6);  mov(eax, memd[ds, eax + 414]);        /* mov eax, [eax+0x19e] */
            ii(0x1011_456a, 5);  call(0x100e_b1b2, -0x2_93bd);         /* call 0x100eb1b2 */
            ii(0x1011_456f, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_4571, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_4572, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_4573, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_4574, 1);  pop(edx);                             /* pop edx */
            ii(0x1011_4575, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_4576, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_4577, 1);  ret();                                /* ret */
        }
    }
}
