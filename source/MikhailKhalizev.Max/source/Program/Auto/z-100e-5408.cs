using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_5408-b1852280")]
        public void Method_100e_5408()
        {
            ii(0x100e_5408, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100e_540d, 5);  call(Definitions.sys_check_available_stack_size, 0x8_0940);/* call 0x10165d52 */
            ii(0x100e_5412, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_5413, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_5414, 1);  push(esi);                            /* push esi */
            ii(0x100e_5415, 1);  push(edi);                            /* push edi */
            ii(0x100e_5416, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_5417, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_5419, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100e_541f, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_5422, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_5425, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100e_5427, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x100e_542c, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100e_542f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_5432, 5);  call(0x1007_6074, -0x6_f3c3);         /* call 0x10076074 */
            ii(0x100e_5437, 2);  test(al, al);                         /* test al, al */
            ii(0x100e_5439, 2);  if(jnz(0x100e_5444, 9)) goto l_0x100e_5444;/* jnz 0x100e5444 */
            ii(0x100e_543b, 7);  cmp(memb[ds, 0x101c_3980], 0);        /* cmp byte [0x101c3980], 0x0 */
            ii(0x100e_5442, 2);  if(jz(0x100e_5458, 0x14)) goto l_0x100e_5458;/* jz 0x100e5458 */
        l_0x100e_5444:
            ii(0x100e_5444, 7);  cmp(memd[ds, 0x101c_38c0], 8);        /* cmp dword [0x101c38c0], 0x8 */
            ii(0x100e_544b, 2);  if(jge(0x100e_5456, 9)) goto l_0x100e_5456;/* jge 0x100e5456 */
            ii(0x100e_544d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_5450, 4);  test(memb[ds, eax + 18], 1);          /* test byte [eax+0x12], 0x1 */
            ii(0x100e_5454, 2);  if(jnz(0x100e_5458, 2)) goto l_0x100e_5458;/* jnz 0x100e5458 */
        l_0x100e_5456:
            ii(0x100e_5456, 2);  jmp(0x100e_545a, 2); goto l_0x100e_545a;/* jmp 0x100e545a */
        l_0x100e_5458:
            ii(0x100e_5458, 2);  jmp(0x100e_5463, 9); goto l_0x100e_5463;/* jmp 0x100e5463 */
        l_0x100e_545a:
            ii(0x100e_545a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_545d, 4);  cmp(memb[ds, eax + 61], 0x10);        /* cmp byte [eax+0x3d], 0x10 */
            ii(0x100e_5461, 2);  if(jnz(0x100e_5465, 2)) goto l_0x100e_5465;/* jnz 0x100e5465 */
        l_0x100e_5463:
            ii(0x100e_5463, 2);  jmp(0x100e_5475, 0x10); goto l_0x100e_5475;/* jmp 0x100e5475 */
        l_0x100e_5465:
            ii(0x100e_5465, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100e_5468, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_546b, 5);  call(0x1015_2bea, 0x6_d77a);          /* call 0x10152bea */
            ii(0x100e_5470, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x100e_5473, 2);  jmp(0x100e_5479, 4); goto l_0x100e_5479;/* jmp 0x100e5479 */
        l_0x100e_5475:
            ii(0x100e_5475, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
        l_0x100e_5479:
            ii(0x100e_5479, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x100e_547c, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_547e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_547f, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_5480, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_5481, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_5482, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_5483, 1);  ret();                                /* ret */
        }
    }
}
