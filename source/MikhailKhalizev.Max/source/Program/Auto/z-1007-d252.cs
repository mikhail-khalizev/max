using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_d252-a8f73a92")]
        public void Method_1007_d252()
        {
            ii(0x1007_d252, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1007_d257, 5);  call(Definitions.sys_check_available_stack_size, 0xe_8af6);/* call 0x10165d52 */
            ii(0x1007_d25c, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_d25d, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_d25e, 1);  push(esi);                            /* push esi */
            ii(0x1007_d25f, 1);  push(edi);                            /* push edi */
            ii(0x1007_d260, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_d261, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_d263, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1007_d269, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_d26c, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_d26f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_d272, 3);  mov(edx, memd[ds, eax + 6]);          /* mov edx, [eax+0x6] */
            ii(0x1007_d275, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1007_d278, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_d27b, 3);  add(eax, 0xa);                        /* add eax, 0xa */
            ii(0x1007_d27e, 5);  call(0x100b_87da, 0x3_b557);          /* call 0x100b87da */
            ii(0x1007_d283, 1);  cwde();                               /* cwde */
            ii(0x1007_d284, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_d286, 2);  if(jnz(0x1007_d28e, 6)) goto l_0x1007_d28e;/* jnz 0x1007d28e */
            ii(0x1007_d288, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
            ii(0x1007_d28c, 2);  jmp(0x1007_d2bd, 0x2f); goto l_0x1007_d2bd;/* jmp 0x1007d2bd */
        l_0x1007_d28e:
            ii(0x1007_d28e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_d291, 4);  mov(dx, memw[ds, eax + 18]);          /* mov dx, [eax+0x12] */
            ii(0x1007_d295, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_d298, 4);  cmp(dx, memw[ds, eax + 20]);          /* cmp dx, [eax+0x14] */
            ii(0x1007_d29c, 2);  if(jl(0x1007_d2ad, 0xf)) goto l_0x1007_d2ad;/* jl 0x1007d2ad */
            ii(0x1007_d29e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_d2a1, 3);  mov(al, memb[ds, eax + 78]);          /* mov al, [eax+0x4e] */
            ii(0x1007_d2a4, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1007_d2a9, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_d2ab, 2);  if(jnz(0x1007_d2b3, 6)) goto l_0x1007_d2b3;/* jnz 0x1007d2b3 */
        l_0x1007_d2ad:
            ii(0x1007_d2ad, 4);  mov(memb[ss, ebp - 16], 1);           /* mov byte [ebp-0x10], 0x1 */
            ii(0x1007_d2b1, 2);  jmp(0x1007_d2b7, 4); goto l_0x1007_d2b7;/* jmp 0x1007d2b7 */
        l_0x1007_d2b3:
            ii(0x1007_d2b3, 4);  mov(memb[ss, ebp - 16], 0);           /* mov byte [ebp-0x10], 0x0 */
        l_0x1007_d2b7:
            ii(0x1007_d2b7, 3);  mov(al, memb[ss, ebp - 16]);          /* mov al, [ebp-0x10] */
            ii(0x1007_d2ba, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
        l_0x1007_d2bd:
            ii(0x1007_d2bd, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1007_d2c0, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_d2c2, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_d2c3, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_d2c4, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_d2c5, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_d2c6, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_d2c7, 1);  ret();                                /* ret */
        }
    }
}
