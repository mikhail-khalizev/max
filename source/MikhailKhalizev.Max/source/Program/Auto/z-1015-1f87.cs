using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_1f87-2a017920")]
        public void Method_1015_1f87()
        {
            ii(0x1015_1f87, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1015_1f8c, 5);  call(Definitions.sys_check_available_stack_size, 0x1_3dc1);/* call 0x10165d52 */
            ii(0x1015_1f91, 1);  push(ebx);                            /* push ebx */
            ii(0x1015_1f92, 1);  push(ecx);                            /* push ecx */
            ii(0x1015_1f93, 1);  push(esi);                            /* push esi */
            ii(0x1015_1f94, 1);  push(edi);                            /* push edi */
            ii(0x1015_1f95, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_1f96, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_1f98, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1015_1f9e, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_1fa1, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1015_1fa4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_1fa7, 4);  cmp(memb[ds, eax + 123], 0);          /* cmp byte [eax+0x7b], 0x0 */
            ii(0x1015_1fab, 2);  if(jnz(0x1015_1fb7, 0xa)) goto l_0x1015_1fb7;/* jnz 0x10151fb7 */
            ii(0x1015_1fad, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_1fb0, 5);  cmp(memw[ds, eax + 8], 0x40);         /* cmp word [eax+0x8], 0x40 */
            ii(0x1015_1fb5, 2);  if(jz(0x1015_1fb9, 2)) goto l_0x1015_1fb9;/* jz 0x10151fb9 */
        l_0x1015_1fb7:
            ii(0x1015_1fb7, 2);  jmp(0x1015_1fd4, 0x1b); goto l_0x1015_1fd4;/* jmp 0x10151fd4 */
        l_0x1015_1fb9:
            ii(0x1015_1fb9, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_1fbc, 3);  mov(eax, memd[ds, eax + 80]);         /* mov eax, [eax+0x50] */
            ii(0x1015_1fbf, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1015_1fc2, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1015_1fc4, 2);  if(jle(0x1015_1fd4, 0xe)) goto l_0x1015_1fd4;/* jle 0x10151fd4 */
            ii(0x1015_1fc6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_1fc9, 4);  dec(memw[ds, eax + 82]);              /* dec word [eax+0x52] */
            ii(0x1015_1fcd, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_1fd0, 4);  mov(memb[ds, eax + 123], 1);          /* mov byte [eax+0x7b], 0x1 */
        l_0x1015_1fd4:
            ii(0x1015_1fd4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_1fd7, 5);  call(0x1014_f08b, -0x2f51);           /* call 0x1014f08b */
            ii(0x1015_1fdc, 5);  mov(edx, 0x101c_37bc);                /* mov edx, 0x101c37bc */
            ii(0x1015_1fe1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_1fe4, 5);  call(0x1007_6d98, -0xd_b251);         /* call 0x10076d98 */
            ii(0x1015_1fe9, 2);  test(al, al);                         /* test al, al */
            ii(0x1015_1feb, 2);  if(jz(0x1015_1ff5, 8)) goto l_0x1015_1ff5;/* jz 0x10151ff5 */
            ii(0x1015_1fed, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_1ff0, 5);  call(0x1010_094d, -0x5_16a8);         /* call 0x1010094d */
        l_0x1015_1ff5:
            ii(0x1015_1ff5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_1ff8, 5);  call(0x1015_26ac, 0x6af);             /* call 0x101526ac */
            ii(0x1015_1ffd, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1015_1fff, 2);  if(jz(0x1015_201b, 0x1a)) goto l_0x1015_201b;/* jz 0x1015201b */
            ii(0x1015_2001, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_2004, 5);  call(0x1015_26ac, 0x6a3);             /* call 0x101526ac */
            ii(0x1015_2009, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1015_200c, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1015_200f, 3);  mov(ebx, memd[ds, eax + 2]);          /* mov ebx, [eax+0x2] */
            ii(0x1015_2012, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_2015, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1015_2018, 3);  call_abs(memd[ds, ebx + 80]);         /* call dword [ebx+0x50] */
        l_0x1015_201b:
            ii(0x1015_201b, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_201d, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_201e, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_201f, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_2020, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1015_2021, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1015_2022, 1);  ret();                                /* ret */
        }
    }
}
