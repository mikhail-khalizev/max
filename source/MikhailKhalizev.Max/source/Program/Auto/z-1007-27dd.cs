using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_27dd-ab712f43")]
        public void Method_1007_27dd()
        {
            ii(0x1007_27dd, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1007_27e2, 5);  call(Definitions.sys_check_available_stack_size, 0xf_356b);/* call 0x10165d52 */
            ii(0x1007_27e7, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_27e8, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_27e9, 1);  push(edx);                            /* push edx */
            ii(0x1007_27ea, 1);  push(esi);                            /* push esi */
            ii(0x1007_27eb, 1);  push(edi);                            /* push edi */
            ii(0x1007_27ec, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_27ed, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_27ef, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1007_27f5, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_27f8, 5);  mov(edx, 0x101c_8184);                /* mov edx, 0x101c8184 */
            ii(0x1007_27fd, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1007_2801, 5);  call(0x1007_2746, -0xc0);             /* call 0x10072746 */
            ii(0x1007_2806, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_2808, 2);  if(jz(0x1007_2813, 9)) goto l_0x1007_2813;/* jz 0x10072813 */
            ii(0x1007_280a, 7);  mov(memd[ss, ebp - 8], 1);            /* mov dword [ebp-0x8], 0x1 */
            ii(0x1007_2811, 2);  jmp(0x1007_283f, 0x2c); goto l_0x1007_283f;/* jmp 0x1007283f */
        l_0x1007_2813:
            ii(0x1007_2813, 5);  mov(edx, 0x101c_81a8);                /* mov edx, 0x101c81a8 */
            ii(0x1007_2818, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1007_281c, 5);  call(0x1007_2746, -0xdb);             /* call 0x10072746 */
            ii(0x1007_2821, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_2823, 2);  if(jz(0x1007_282e, 9)) goto l_0x1007_282e;/* jz 0x1007282e */
            ii(0x1007_2825, 7);  mov(memd[ss, ebp - 8], 1);            /* mov dword [ebp-0x8], 0x1 */
            ii(0x1007_282c, 2);  jmp(0x1007_283f, 0x11); goto l_0x1007_283f;/* jmp 0x1007283f */
        l_0x1007_282e:
            ii(0x1007_282e, 5);  mov(edx, 0x101c_819c);                /* mov edx, 0x101c819c */
            ii(0x1007_2833, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1007_2837, 5);  call(0x1007_2746, -0xf6);             /* call 0x10072746 */
            ii(0x1007_283c, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
        l_0x1007_283f:
            ii(0x1007_283f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_2842, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_2844, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_2845, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_2846, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_2847, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_2848, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_2849, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_284a, 1);  ret();                                /* ret */
        }
    }
}
