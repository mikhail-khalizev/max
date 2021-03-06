using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_7ea0-19c6f5b9")]
        public void /* sys */ Method_1016_7ea0()
        {
            ii(0x1016_7ea0, 1);  push(ebx);                            /* push ebx */
            ii(0x1016_7ea1, 1);  push(ecx);                            /* push ecx */
            ii(0x1016_7ea2, 1);  push(edx);                            /* push edx */
            ii(0x1016_7ea3, 3);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1016_7ea6, 5);  mov(edx, 0xffff_ffff);                /* mov edx, 0xffffffff */
            ii(0x1016_7eab, 6);  mov(ebx, memd[ds, 0x101b_ddbc]);      /* mov ebx, [0x101bddbc] */
            ii(0x1016_7eb1, 3);  mov(memd[ss, esp], edx);              /* mov [esp], edx */
            ii(0x1016_7eb4, 2);  test(ebx, ebx);                       /* test ebx, ebx */
            ii(0x1016_7eb6, 2);  if(jnz(0x1016_7ebc, 4)) goto l_0x1016_7ebc;/* jnz 0x10167ebc */
            ii(0x1016_7eb8, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1016_7eba, 2);  jmp(0x1016_7ef8, 0x3c); goto l_0x1016_7ef8;/* jmp 0x10167ef8 */
        l_0x1016_7ebc:
            ii(0x1016_7ebc, 6);  mov(ecx, memd[ds, 0x101c_b2d8]);      /* mov ecx, [0x101cb2d8] */
            ii(0x1016_7ec2, 1);  dec(ecx);                             /* dec ecx */
            ii(0x1016_7ec3, 3);  cmp(ecx, 1);                          /* cmp ecx, 0x1 */
            ii(0x1016_7ec6, 2);  if(jl(0x1016_7ef5, 0x2d)) goto l_0x1016_7ef5;/* jl 0x10167ef5 */
            ii(0x1016_7ec8, 7);  lea(ebx, memd[ds, ecx * 4]);          /* lea ebx, [ecx*4] */
        l_0x1016_7ecf:
            ii(0x1016_7ecf, 2);  mov(edx, esp);                        /* mov edx, esp */
            ii(0x1016_7ed1, 6);  mov(eax, memd[ds, ebx + 0x101c_b1fc]);/* mov eax, [ebx+0x101cb1fc] */
            ii(0x1016_7ed7, 5);  call(/* sys */ 0x1016_8e14, 0xf38);   /* call 0x10168e14 */
            ii(0x1016_7edc, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1016_7ede, 2);  if(jz(0x1016_7ef5, 0x15)) goto l_0x1016_7ef5;/* jz 0x10167ef5 */
            ii(0x1016_7ee0, 6);  mov(eax, memd[ds, ebx + 0x101c_b1fc]);/* mov eax, [ebx+0x101cb1fc] */
            ii(0x1016_7ee6, 4);  test(memb[ds, eax + 4], 0x10);        /* test byte [eax+0x4], 0x10 */
            ii(0x1016_7eea, 2);  if(jnz(0x1016_7ef5, 9)) goto l_0x1016_7ef5;/* jnz 0x10167ef5 */
            ii(0x1016_7eec, 3);  sub(ebx, 4);                          /* sub ebx, 0x4 */
            ii(0x1016_7eef, 1);  dec(ecx);                             /* dec ecx */
            ii(0x1016_7ef0, 3);  cmp(ebx, 4);                          /* cmp ebx, 0x4 */
            ii(0x1016_7ef3, 2);  if(jge(0x1016_7ecf, -0x26)) goto l_0x1016_7ecf;/* jge 0x10167ecf */
        l_0x1016_7ef5:
            ii(0x1016_7ef5, 3);  mov(eax, memd[ss, esp]);              /* mov eax, [esp] */
        l_0x1016_7ef8:
            ii(0x1016_7ef8, 3);  add(esp, 4);                          /* add esp, 0x4 */
            ii(0x1016_7efb, 1);  pop(edx);                             /* pop edx */
            ii(0x1016_7efc, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1016_7efd, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1016_7efe, 1);  ret();                                /* ret */
        }
    }
}
