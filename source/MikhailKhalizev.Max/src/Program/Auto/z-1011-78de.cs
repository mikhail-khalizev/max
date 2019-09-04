using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_78de-7dd3e6f2")]
        public void Method_1011_78de()
        {
            ii(0x1011_78de, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1011_78e3, 5);  call(Definitions.sys_check_available_stack_size, 0x4_e46a);/* call 0x10165d52 */
            ii(0x1011_78e8, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_78e9, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_78ea, 1);  push(esi);                            /* push esi */
            ii(0x1011_78eb, 1);  push(edi);                            /* push edi */
            ii(0x1011_78ec, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_78ed, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_78ef, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1011_78f5, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_78f8, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1011_78fb, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_78fe, 3);  mov(eax, memd[ds, eax + 8]);          /* mov eax, [eax+0x8] */
            ii(0x1011_7901, 5);  call(Definitions.sys_strlen, 0x5_a5c1);/* call 0x10171ec7 */
            ii(0x1011_7906, 1);  inc(eax);                             /* inc eax */
            ii(0x1011_7907, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1011_790a, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1011_790e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_7911, 5);  call(0x1013_c0fa, 0x2_47e4);          /* call 0x1013c0fa */
            ii(0x1011_7916, 4);  movsx(ebx, memw[ss, ebp - 12]);       /* movsx ebx, word [ebp-0xc] */
            ii(0x1011_791a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_791d, 3);  mov(edx, memd[ds, eax + 8]);          /* mov edx, [eax+0x8] */
            ii(0x1011_7920, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_7923, 5);  call(0x1013_c055, 0x2_472d);          /* call 0x1013c055 */
            ii(0x1011_7928, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_792b, 3);  add(eax, 0xc);                        /* add eax, 0xc */
            ii(0x1011_792e, 5);  call(0x1007_6600, -0xa_1333);         /* call 0x10076600 */
            ii(0x1011_7933, 3);  mov(ebx, memd[ss, ebp - 4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1011_7936, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1011_7938, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1011_793a, 5);  call(0x1013_c25c, 0x2_491d);          /* call 0x1013c25c */
            ii(0x1011_793f, 5);  mov(ebx, 4);                          /* mov ebx, 0x4 */
            ii(0x1011_7944, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1011_7947, 3);  add(edx, 0x10);                       /* add edx, 0x10 */
            ii(0x1011_794a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_794d, 5);  call(0x1013_c055, 0x2_4703);          /* call 0x1013c055 */
            ii(0x1011_7952, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_7955, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_7957, 3);  mov(dl, memb[ds, eax + 20]);          /* mov dl, [eax+0x14] */
            ii(0x1011_795a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_795d, 5);  call(0x100c_b818, -0x4_c14a);         /* call 0x100cb818 */
            ii(0x1011_7962, 5);  mov(ebx, 2);                          /* mov ebx, 0x2 */
            ii(0x1011_7967, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1011_796a, 3);  add(edx, 6);                          /* add edx, 0x6 */
            ii(0x1011_796d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_7970, 5);  call(0x1013_c055, 0x2_46e0);          /* call 0x1013c055 */
            ii(0x1011_7975, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_7977, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_7978, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_7979, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_797a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_797b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_797c, 1);  ret();                                /* ret */
        }
    }
}
