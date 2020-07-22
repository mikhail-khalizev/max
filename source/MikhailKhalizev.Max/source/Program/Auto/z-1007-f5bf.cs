using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_f5bf-bb4fb7bb")]
        public void Method_1007_f5bf()
        {
            ii(0x1007_f5bf, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1007_f5c4, 5);  call(Definitions.sys_check_available_stack_size, 0xe_6789);/* call 0x10165d52 */
            ii(0x1007_f5c9, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_f5ca, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_f5cb, 1);  push(esi);                            /* push esi */
            ii(0x1007_f5cc, 1);  push(edi);                            /* push edi */
            ii(0x1007_f5cd, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_f5ce, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_f5d0, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1007_f5d6, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_f5d9, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_f5dc, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_f5df, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_f5e2, 3);  add(eax, 0x18);                       /* add eax, 0x18 */
            ii(0x1007_f5e5, 5);  call(0x1007_62cc, -0x931e);           /* call 0x100762cc */
            ii(0x1007_f5ea, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_f5ec, 2);  if(jz(0x1007_f5f4, 6)) goto l_0x1007_f5f4;/* jz 0x1007f5f4 */
            ii(0x1007_f5ee, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
            ii(0x1007_f5f2, 2);  jmp(0x1007_f5f8, 4); goto l_0x1007_f5f8;/* jmp 0x1007f5f8 */
        l_0x1007_f5f4:
            ii(0x1007_f5f4, 4);  mov(memb[ss, ebp - 12], 2);           /* mov byte [ebp-0xc], 0x2 */
        l_0x1007_f5f8:
            ii(0x1007_f5f8, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1007_f5fb, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_f5fd, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_f5fe, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_f5ff, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_f600, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_f601, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_f602, 1);  ret();                                /* ret */
        }
    }
}
