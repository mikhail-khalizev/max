using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_6f53-163d61a4")]
        public void Method_1011_6f53()
        {
            ii(0x1011_6f53, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1011_6f58, 5);  call(Definitions.sys_check_available_stack_size, 0x4_edf5);/* call 0x10165d52 */
            ii(0x1011_6f5d, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_6f5e, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_6f5f, 1);  push(edx);                            /* push edx */
            ii(0x1011_6f60, 1);  push(esi);                            /* push esi */
            ii(0x1011_6f61, 1);  push(edi);                            /* push edi */
            ii(0x1011_6f62, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_6f63, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_6f65, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1011_6f6b, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_6f6e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_6f71, 4);  mov(memb[ds, eax + 49], 0);           /* mov byte [eax+0x31], 0x0 */
            ii(0x1011_6f75, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_6f78, 4);  mov(memb[ds, eax + 50], 0);           /* mov byte [eax+0x32], 0x0 */
            ii(0x1011_6f7c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_6f7f, 4);  mov(memb[ds, eax + 59], 0);           /* mov byte [eax+0x3b], 0x0 */
        l_0x1011_6f83:
            ii(0x1011_6f83, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_6f86, 4);  cmp(memb[ds, eax + 49], 0);           /* cmp byte [eax+0x31], 0x0 */
            ii(0x1011_6f8a, 2);  if(jnz(0x1011_6f95, 9)) goto l_0x1011_6f95;/* jnz 0x10116f95 */
            ii(0x1011_6f8c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_6f8f, 4);  cmp(memb[ds, eax + 50], 0);           /* cmp byte [eax+0x32], 0x0 */
            ii(0x1011_6f93, 2);  if(jz(0x1011_6f9a, 5)) goto l_0x1011_6f9a;/* jz 0x10116f9a */
        l_0x1011_6f95:
            ii(0x1011_6f95, 5);  jmp(0x1011_701f, 0x85); goto l_0x1011_701f;/* jmp 0x1011701f */
        l_0x1011_6f9a:
            ii(0x1011_6f9a, 5);  call(/* sys */ 0x1016_b208, 0x5_4269);/* call 0x1016b208 */
            ii(0x1011_6f9f, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1011_6fa2, 4);  cmp(memd[ss, ebp - 12], 0);           /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1011_6fa6, 2);  if(jle(0x1011_6fb1, 9)) goto l_0x1011_6fb1;/* jle 0x10116fb1 */
            ii(0x1011_6fa8, 7);  cmp(memd[ss, ebp - 12], 0x7000);      /* cmp dword [ebp-0xc], 0x7000 */
            ii(0x1011_6faf, 2);  if(jl(0x1011_6fb3, 2)) goto l_0x1011_6fb3;/* jl 0x10116fb3 */
        l_0x1011_6fb1:
            ii(0x1011_6fb1, 2);  jmp(0x1011_6fba, 7); goto l_0x1011_6fba;/* jmp 0x10116fba */
        l_0x1011_6fb3:
            ii(0x1011_6fb3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_6fb6, 4);  mov(memb[ds, eax + 59], 0);           /* mov byte [eax+0x3b], 0x0 */
        l_0x1011_6fba:
            ii(0x1011_6fba, 4);  cmp(memd[ss, ebp - 12], 0xd);         /* cmp dword [ebp-0xc], 0xd */
            ii(0x1011_6fbe, 2);  if(jnz(0x1011_6fc9, 9)) goto l_0x1011_6fc9;/* jnz 0x10116fc9 */
            ii(0x1011_6fc0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_6fc3, 4);  mov(memb[ds, eax + 49], 1);           /* mov byte [eax+0x31], 0x1 */
            ii(0x1011_6fc7, 2);  jmp(0x1011_6fd6, 0xd); goto l_0x1011_6fd6;/* jmp 0x10116fd6 */
        l_0x1011_6fc9:
            ii(0x1011_6fc9, 4);  cmp(memd[ss, ebp - 12], 0x1b);        /* cmp dword [ebp-0xc], 0x1b */
            ii(0x1011_6fcd, 2);  if(jnz(0x1011_6fd6, 7)) goto l_0x1011_6fd6;/* jnz 0x10116fd6 */
            ii(0x1011_6fcf, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_6fd2, 4);  mov(memb[ds, eax + 50], 1);           /* mov byte [eax+0x32], 0x1 */
        l_0x1011_6fd6:
            ii(0x1011_6fd6, 7);  add(memd[ss, ebp - 12], 0xffff_9000); /* add dword [ebp-0xc], 0xffff9000 */
            ii(0x1011_6fdd, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_6fe0, 4);  cmp(memb[ds, eax + 59], 0);           /* cmp byte [eax+0x3b], 0x0 */
            ii(0x1011_6fe4, 2);  if(jnz(0x1011_700b, 0x25)) goto l_0x1011_700b;/* jnz 0x1011700b */
            ii(0x1011_6fe6, 4);  cmp(memd[ss, ebp - 12], 0xd);         /* cmp dword [ebp-0xc], 0xd */
            ii(0x1011_6fea, 2);  if(jnz(0x1011_6ff9, 0xd)) goto l_0x1011_6ff9;/* jnz 0x10116ff9 */
            ii(0x1011_6fec, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_6fef, 3);  mov(eax, memd[ds, eax + 51]);         /* mov eax, [eax+0x33] */
            ii(0x1011_6ff2, 5);  call(0x100c_fbbe, -0x4_7439);         /* call 0x100cfbbe */
            ii(0x1011_6ff7, 2);  jmp(0x1011_7004, 0xb); goto l_0x1011_7004;/* jmp 0x10117004 */
        l_0x1011_6ff9:
            ii(0x1011_6ff9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_6ffc, 3);  mov(eax, memd[ds, eax + 55]);         /* mov eax, [eax+0x37] */
            ii(0x1011_6fff, 5);  call(0x100c_fbbe, -0x4_7446);         /* call 0x100cfbbe */
        l_0x1011_7004:
            ii(0x1011_7004, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_7007, 4);  mov(memb[ds, eax + 59], 1);           /* mov byte [eax+0x3b], 0x1 */
        l_0x1011_700b:
            ii(0x1011_700b, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1011_7010, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1011_7015, 5);  call(0x1010_0e32, -0x1_61e8);         /* call 0x10100e32 */
            ii(0x1011_701a, 5);  jmp(0x1011_6f83, -0x9c); goto l_0x1011_6f83;/* jmp 0x10116f83 */
        l_0x1011_701f:
            ii(0x1011_701f, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1011_7021, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_7024, 3);  mov(al, memb[ds, edx + 49]);          /* mov al, [edx+0x31] */
            ii(0x1011_7027, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_702a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_702d, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_702f, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_7030, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_7031, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_7032, 1);  pop(edx);                             /* pop edx */
            ii(0x1011_7033, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_7034, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_7035, 1);  ret();                                /* ret */
        }
    }
}
