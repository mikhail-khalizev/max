using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_41da-e54d2ba6")]
        public void Method_1015_41da()
        {
            ii(0x1015_41da, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1015_41df, 5);  call(Definitions.sys_check_available_stack_size, 0x1_1b6e);/* call 0x10165d52 */
            ii(0x1015_41e4, 1);  push(ebx);                            /* push ebx */
            ii(0x1015_41e5, 1);  push(ecx);                            /* push ecx */
            ii(0x1015_41e6, 1);  push(edx);                            /* push edx */
            ii(0x1015_41e7, 1);  push(esi);                            /* push esi */
            ii(0x1015_41e8, 1);  push(edi);                            /* push edi */
            ii(0x1015_41e9, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_41ea, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_41ec, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1015_41f2, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1015_41f5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_41f8, 3);  mov(al, memb[ds, eax + 94]);          /* mov al, [eax+0x5e] */
            ii(0x1015_41fb, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1015_4200, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1015_4202, 2);  if(jnz(0x1015_4215, 0x11)) goto l_0x1015_4215;/* jnz 0x10154215 */
            ii(0x1015_4204, 5);  mov(edx, 0x101c_37bc);                /* mov edx, 0x101c37bc */
            ii(0x1015_4209, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_420c, 5);  call(0x1007_6d98, -0xd_d479);         /* call 0x10076d98 */
            ii(0x1015_4211, 2);  test(al, al);                         /* test al, al */
            ii(0x1015_4213, 2);  if(jnz(0x1015_4217, 2)) goto l_0x1015_4217;/* jnz 0x10154217 */
        l_0x1015_4215:
            ii(0x1015_4215, 2);  jmp(0x1015_4232, 0x1b); goto l_0x1015_4232;/* jmp 0x10154232 */
        l_0x1015_4217:
            ii(0x1015_4217, 5);  call(0x1010_2bf8, -0x5_1624);         /* call 0x10102bf8 */
            ii(0x1015_421c, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
            ii(0x1015_421e, 2);  mov(cl, al);                          /* mov cl, al */
            ii(0x1015_4220, 5);  mov(ebx, 0x12);                       /* mov ebx, 0x12 */
            ii(0x1015_4225, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_4228, 5);  mov(eax, 0x101c_7278);                /* mov eax, 0x101c7278 */
            ii(0x1015_422d, 5);  call(0x1013_d5c0, -0x1_6c72);         /* call 0x1013d5c0 */
        l_0x1015_4232:
            ii(0x1015_4232, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_4235, 5);  call(0x1014_9fa8, -0xa292);           /* call 0x10149fa8 */
            ii(0x1015_423a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_423d, 3);  mov(dl, memb[ds, eax + 94]);          /* mov dl, [eax+0x5e] */
            ii(0x1015_4240, 2);  inc(dl);                              /* inc dl */
            ii(0x1015_4242, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_4245, 3);  and(dl, 0x3f);                        /* and dl, 0x3f */
            ii(0x1015_4248, 3);  mov(memb[ds, eax + 94], dl);          /* mov [eax+0x5e], dl */
            ii(0x1015_424b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_424e, 3);  mov(al, memb[ds, eax + 94]);          /* mov al, [eax+0x5e] */
            ii(0x1015_4251, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1015_4256, 3);  cmp(eax, 4);                          /* cmp eax, 0x4 */
            ii(0x1015_4259, 2);  if(jg(0x1015_4287, 0x2c)) goto l_0x1015_4287;/* jg 0x10154287 */
            ii(0x1015_425b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_425e, 8);  sub(memw[ds, eax + 217], 0x10);       /* sub word [eax+0xd9], 0x10 */
            ii(0x1015_4266, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_4269, 8);  sub(memw[ds, eax + 219], 0x10);       /* sub word [eax+0xdb], 0x10 */
            ii(0x1015_4271, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_4274, 5);  call(0x1014_9cd1, -0xa5a8);           /* call 0x10149cd1 */
            ii(0x1015_4279, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_427c, 5);  call(0x1014_9fa8, -0xa2d9);           /* call 0x10149fa8 */
            ii(0x1015_4281, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x1015_4285, 2);  jmp(0x1015_4292, 0xb); goto l_0x1015_4292;/* jmp 0x10154292 */
        l_0x1015_4287:
            ii(0x1015_4287, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_428a, 4);  or(memb[ds, eax + 20], 1);            /* or byte [eax+0x14], 0x1 */
            ii(0x1015_428e, 4);  mov(memb[ss, ebp - 8], 1);            /* mov byte [ebp-0x8], 0x1 */
        l_0x1015_4292:
            ii(0x1015_4292, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1015_4295, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_4297, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_4298, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_4299, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_429a, 1);  pop(edx);                             /* pop edx */
            ii(0x1015_429b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1015_429c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1015_429d, 1);  ret();                                /* ret */
        }
    }
}
