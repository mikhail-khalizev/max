using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_4162-ed253841")]
        public void Method_100c_4162()
        {
            ii(0x100c_4162, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100c_4167, 5);  call(Definitions.sys_check_available_stack_size, 0xa_1be6);/* call 0x10165d52 */
            ii(0x100c_416c, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_416d, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_416e, 1);  push(edx);                            /* push edx */
            ii(0x100c_416f, 1);  push(esi);                            /* push esi */
            ii(0x100c_4170, 1);  push(edi);                            /* push edi */
            ii(0x100c_4171, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_4172, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_4174, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100c_417a, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_417d, 5);  mov(eax, 0x4c);                       /* mov eax, 0x4c */
            ii(0x100c_4182, 5);  call(0x1007_5fdc, -0x4_e1ab);         /* call 0x10075fdc */
            ii(0x100c_4187, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x100c_418a, 2);  if(jge(0x100c_419a, 0xe)) goto l_0x100c_419a;/* jge 0x100c419a */
            ii(0x100c_418c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_418f, 6);  mov(memw[ds, eax + 7], 0);            /* mov word [eax+0x7], 0x0 */
            ii(0x100c_4195, 5);  jmp(0x100c_42a4, 0x10a); goto l_0x100c_42a4;/* jmp 0x100c42a4 */
        l_0x100c_419a:
            ii(0x100c_419a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_419d, 3);  mov(al, memb[ds, eax + 2]);           /* mov al, [eax+0x2] */
            ii(0x100c_41a0, 3);  mov(memb[ss, ebp - 8], al);           /* mov [ebp-0x8], al */
            ii(0x100c_41a3, 5);  jmp(0x100c_4265, 0xbd); goto l_0x100c_4265;/* jmp 0x100c4265 */
        l_0x100c_41a8:
            ii(0x100c_41a8, 5);  call(/* sys */ 0x1016_5e9b, 0xa_1cee);/* call 0x10165e9b */
            ii(0x100c_41ad, 3);  imul(eax, eax, 7);                    /* imul eax, eax, 0x7 */
            ii(0x100c_41b0, 3);  shr(eax, 0xf);                        /* shr eax, 0xf */
            ii(0x100c_41b3, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100c_41b5, 5);  call(/* sys */ 0x1016_5e9b, 0xa_1ce1);/* call 0x10165e9b */
            ii(0x100c_41ba, 3);  imul(eax, eax, 7);                    /* imul eax, eax, 0x7 */
            ii(0x100c_41bd, 3);  shr(eax, 0xf);                        /* shr eax, 0xf */
            ii(0x100c_41c0, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100c_41c2, 3);  imul(edx, eax, 0xc);                  /* imul edx, eax, 0xc */
            ii(0x100c_41c5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_41c8, 4);  mov(memw[ds, eax + 7], dx);           /* mov [eax+0x7], dx */
            ii(0x100c_41cc, 5);  jmp(0x100c_42a4, 0xd3); goto l_0x100c_42a4;/* jmp 0x100c42a4 */
        l_0x100c_41d1:
            ii(0x100c_41d1, 5);  call(/* sys */ 0x1016_5e9b, 0xa_1cc5);/* call 0x10165e9b */
            ii(0x100c_41d6, 3);  imul(eax, eax, 0x64);                 /* imul eax, eax, 0x64 */
            ii(0x100c_41d9, 3);  shr(eax, 0xf);                        /* shr eax, 0xf */
            ii(0x100c_41dc, 1);  inc(eax);                             /* inc eax */
            ii(0x100c_41dd, 3);  cmp(eax, 0x32);                       /* cmp eax, 0x32 */
            ii(0x100c_41e0, 2);  if(jge(0x100c_4208, 0x26)) goto l_0x100c_4208;/* jge 0x100c4208 */
            ii(0x100c_41e2, 5);  call(/* sys */ 0x1016_5e9b, 0xa_1cb4);/* call 0x10165e9b */
            ii(0x100c_41e7, 3);  lea(eax, memd[ds, eax + eax * 4]);    /* lea eax, [eax+eax*4] */
            ii(0x100c_41ea, 3);  shr(eax, 0xf);                        /* shr eax, 0xf */
            ii(0x100c_41ed, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100c_41ef, 5);  call(/* sys */ 0x1016_5e9b, 0xa_1ca7);/* call 0x10165e9b */
            ii(0x100c_41f4, 3);  lea(eax, memd[ds, eax + eax * 4]);    /* lea eax, [eax+eax*4] */
            ii(0x100c_41f7, 3);  shr(eax, 0xf);                        /* shr eax, 0xf */
            ii(0x100c_41fa, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100c_41fc, 3);  imul(edx, eax, 6);                    /* imul edx, eax, 0x6 */
            ii(0x100c_41ff, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_4202, 4);  mov(memw[ds, eax + 7], dx);           /* mov [eax+0x7], dx */
            ii(0x100c_4206, 2);  jmp(0x100c_4211, 9); goto l_0x100c_4211;/* jmp 0x100c4211 */
        l_0x100c_4208:
            ii(0x100c_4208, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_420b, 6);  mov(memw[ds, eax + 7], 0);            /* mov word [eax+0x7], 0x0 */
        l_0x100c_4211:
            ii(0x100c_4211, 5);  jmp(0x100c_42a4, 0x8e); goto l_0x100c_42a4;/* jmp 0x100c42a4 */
        l_0x100c_4216:
            ii(0x100c_4216, 5);  call(/* sys */ 0x1016_5e9b, 0xa_1c80);/* call 0x10165e9b */
            ii(0x100c_421b, 3);  imul(eax, eax, 0x64);                 /* imul eax, eax, 0x64 */
            ii(0x100c_421e, 3);  shr(eax, 0xf);                        /* shr eax, 0xf */
            ii(0x100c_4221, 1);  inc(eax);                             /* inc eax */
            ii(0x100c_4222, 3);  cmp(eax, 0x19);                       /* cmp eax, 0x19 */
            ii(0x100c_4225, 2);  if(jge(0x100c_424d, 0x26)) goto l_0x100c_424d;/* jge 0x100c424d */
            ii(0x100c_4227, 5);  call(/* sys */ 0x1016_5e9b, 0xa_1c6f);/* call 0x10165e9b */
            ii(0x100c_422c, 3);  lea(eax, memd[ds, eax + eax * 4]);    /* lea eax, [eax+eax*4] */
            ii(0x100c_422f, 3);  shr(eax, 0xf);                        /* shr eax, 0xf */
            ii(0x100c_4232, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100c_4234, 5);  call(/* sys */ 0x1016_5e9b, 0xa_1c62);/* call 0x10165e9b */
            ii(0x100c_4239, 3);  lea(eax, memd[ds, eax + eax * 4]);    /* lea eax, [eax+eax*4] */
            ii(0x100c_423c, 3);  shr(eax, 0xf);                        /* shr eax, 0xf */
            ii(0x100c_423f, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100c_4241, 3);  imul(edx, eax, 6);                    /* imul edx, eax, 0x6 */
            ii(0x100c_4244, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_4247, 4);  mov(memw[ds, eax + 7], dx);           /* mov [eax+0x7], dx */
            ii(0x100c_424b, 2);  jmp(0x100c_4256, 9); goto l_0x100c_4256;/* jmp 0x100c4256 */
        l_0x100c_424d:
            ii(0x100c_424d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_4250, 6);  mov(memw[ds, eax + 7], 0);            /* mov word [eax+0x7], 0x0 */
        l_0x100c_4256:
            ii(0x100c_4256, 2);  jmp(0x100c_42a4, 0x4c); goto l_0x100c_42a4;/* jmp 0x100c42a4 */
        l_0x100c_4258:
            ii(0x100c_4258, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_425b, 6);  mov(memw[ds, eax + 7], 0);            /* mov word [eax+0x7], 0x0 */
            ii(0x100c_4261, 2);  jmp(0x100c_42a4, 0x41); goto l_0x100c_42a4;/* jmp 0x100c42a4 */
        l_0x100c_4263:
            ii(0x100c_4263, 2);  jmp(0x100c_42a4, 0x3f); goto l_0x100c_42a4;/* jmp 0x100c42a4 */
        l_0x100c_4265:
            ii(0x100c_4265, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x100c_4268, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x100c_426b, 4);  cmp(memb[ss, ebp - 12], 3);           /* cmp byte [ebp-0xc], 0x3 */
            ii(0x100c_426f, 2);  if(jb(0x100c_428d, 0x1c)) goto l_0x100c_428d;/* jb 0x100c428d */
            ii(0x100c_4271, 4);  cmp(memb[ss, ebp - 12], 4);           /* cmp byte [ebp-0xc], 0x4 */
            ii(0x100c_4275, 6);  if(jbe(0x100c_41d1, -0xaa)) goto l_0x100c_41d1;/* jbe 0x100c41d1 */
            ii(0x100c_427b, 4);  cmp(memb[ss, ebp - 12], 6);           /* cmp byte [ebp-0xc], 0x6 */
            ii(0x100c_427f, 2);  if(jbe(0x100c_4258, -0x29)) goto l_0x100c_4258;/* jbe 0x100c4258 */
            ii(0x100c_4281, 4);  cmp(memb[ss, ebp - 12], 9);           /* cmp byte [ebp-0xc], 0x9 */
            ii(0x100c_4285, 2);  if(jbe(0x100c_4216, -0x71)) goto l_0x100c_4216;/* jbe 0x100c4216 */
            ii(0x100c_4287, 2);  jmp(0x100c_4263, -0x26); goto l_0x100c_4263;/* jmp 0x100c4263 */
        //  ii(0x100c_4289, 4);  Недостижимый код.
        l_0x100c_428d:
            ii(0x100c_428d, 4);  cmp(memb[ss, ebp - 12], 1);           /* cmp byte [ebp-0xc], 0x1 */
            ii(0x100c_4291, 2);  if(jb(0x100c_42a2, 0xf)) goto l_0x100c_42a2;/* jb 0x100c42a2 */
            ii(0x100c_4293, 4);  cmp(memb[ss, ebp - 12], 1);           /* cmp byte [ebp-0xc], 0x1 */
            ii(0x100c_4297, 6);  if(jbe(0x100c_41a8, -0xf5)) goto l_0x100c_41a8;/* jbe 0x100c41a8 */
            ii(0x100c_429d, 5);  jmp(0x100c_4216, -0x8c); goto l_0x100c_4216;/* jmp 0x100c4216 */
        l_0x100c_42a2:
            ii(0x100c_42a2, 2);  jmp(0x100c_4263, -0x41); goto l_0x100c_4263;/* jmp 0x100c4263 */
        l_0x100c_42a4:
            ii(0x100c_42a4, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_42a6, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_42a7, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_42a8, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_42a9, 1);  pop(edx);                             /* pop edx */
            ii(0x100c_42aa, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_42ab, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_42ac, 1);  ret();                                /* ret */
        }
    }
}
