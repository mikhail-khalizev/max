using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_8347-9cca55c9")]
        public void Method_1010_8347()
        {
            ii(0x1010_8347, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1010_834c, 5);  call(Definitions.sys_check_available_stack_size, 0x5_da01);/* call 0x10165d52 */
            ii(0x1010_8351, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_8352, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_8353, 1);  push(esi);                            /* push esi */
            ii(0x1010_8354, 1);  push(edi);                            /* push edi */
            ii(0x1010_8355, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_8356, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_8358, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1010_835e, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_8361, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1010_8364, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_8367, 3);  mov(edx, memd[ds, eax + 8]);          /* mov edx, [eax+0x8] */
            ii(0x1010_836a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_836d, 2);  cmp(edx, memd[ds, eax]);              /* cmp edx, [eax] */
            ii(0x1010_836f, 2);  if(jle(0x1010_837e, 0xd)) goto l_0x1010_837e;/* jle 0x1010837e */
            ii(0x1010_8371, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_8374, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x1010_8376, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_8379, 3);  cmp(edx, memd[ds, eax + 8]);          /* cmp edx, [eax+0x8] */
            ii(0x1010_837c, 2);  if(jl(0x1010_8380, 2)) goto l_0x1010_8380;/* jl 0x10108380 */
        l_0x1010_837e:
            ii(0x1010_837e, 2);  jmp(0x1010_838e, 0xe); goto l_0x1010_838e;/* jmp 0x1010838e */
        l_0x1010_8380:
            ii(0x1010_8380, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_8383, 3);  mov(edx, memd[ds, eax + 12]);         /* mov edx, [eax+0xc] */
            ii(0x1010_8386, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_8389, 3);  cmp(edx, memd[ds, eax + 4]);          /* cmp edx, [eax+0x4] */
            ii(0x1010_838c, 2);  if(jg(0x1010_8390, 2)) goto l_0x1010_8390;/* jg 0x10108390 */
        l_0x1010_838e:
            ii(0x1010_838e, 2);  jmp(0x1010_839e, 0xe); goto l_0x1010_839e;/* jmp 0x1010839e */
        l_0x1010_8390:
            ii(0x1010_8390, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_8393, 3);  mov(edx, memd[ds, eax + 4]);          /* mov edx, [eax+0x4] */
            ii(0x1010_8396, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_8399, 3);  cmp(edx, memd[ds, eax + 12]);         /* cmp edx, [eax+0xc] */
            ii(0x1010_839c, 2);  if(jl(0x1010_83a0, 2)) goto l_0x1010_83a0;/* jl 0x101083a0 */
        l_0x1010_839e:
            ii(0x1010_839e, 2);  jmp(0x1010_83a6, 6); goto l_0x1010_83a6;/* jmp 0x101083a6 */
        l_0x1010_83a0:
            ii(0x1010_83a0, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1010_83a4, 2);  jmp(0x1010_83aa, 4); goto l_0x1010_83aa;/* jmp 0x101083aa */
        l_0x1010_83a6:
            ii(0x1010_83a6, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
        l_0x1010_83aa:
            ii(0x1010_83aa, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1010_83ad, 3);  mov(memb[ss, ebp - 16], al);          /* mov [ebp-0x10], al */
            ii(0x1010_83b0, 3);  mov(al, memb[ss, ebp - 16]);          /* mov al, [ebp-0x10] */
            ii(0x1010_83b3, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_83b5, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_83b6, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_83b7, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_83b8, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_83b9, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_83ba, 1);  ret();                                /* ret */
        }
    }
}
