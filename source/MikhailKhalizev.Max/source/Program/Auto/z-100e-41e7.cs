using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_41e7-dc91eaf7")]
        public void Method_100e_41e7()
        {
            ii(0x100e_41e7, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100e_41ec, 5);  call(Definitions.sys_check_available_stack_size, 0x8_1b61);/* call 0x10165d52 */
            ii(0x100e_41f1, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_41f2, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_41f3, 1);  push(esi);                            /* push esi */
            ii(0x100e_41f4, 1);  push(edi);                            /* push edi */
            ii(0x100e_41f5, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_41f6, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_41f8, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100e_41fe, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_4201, 3);  mov(memb[ss, ebp - 4], dl);           /* mov [ebp-0x4], dl */
            ii(0x100e_4204, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_4207, 3);  add(eax, 0x1c);                       /* add eax, 0x1c */
            ii(0x100e_420a, 5);  call(0x1007_6338, -0x6_ded7);         /* call 0x10076338 */
            ii(0x100e_420f, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100e_4211, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100e_4214, 5);  call(0x1007_64b8, -0x6_dd61);         /* call 0x100764b8 */
            ii(0x100e_4219, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_421c, 5);  call(0x100e_3fc4, -0x25d);            /* call 0x100e3fc4 */
            ii(0x100e_4221, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100e_4228, 2);  jmp(0x100e_4230, 6); goto l_0x100e_4230;/* jmp 0x100e4230 */
        l_0x100e_422a:
            ii(0x100e_422a, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_422d, 3);  inc(memd[ss, ebp - 16]);              /* inc dword [ebp-0x10] */
        l_0x100e_4230:
            ii(0x100e_4230, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_4233, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100e_4236, 4);  cmp(ax, memw[ds, edx + 38]);          /* cmp ax, [edx+0x26] */
            ii(0x100e_423a, 2);  if(jge(0x100e_4246, 0xa)) goto l_0x100e_4246;/* jge 0x100e4246 */
            ii(0x100e_423c, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100e_423f, 5);  call(0x1007_6bf8, -0x6_d64c);         /* call 0x10076bf8 */
            ii(0x100e_4244, 2);  jmp(0x100e_422a, -0x1c); goto l_0x100e_422a;/* jmp 0x100e422a */
        l_0x100e_4246:
            ii(0x100e_4246, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100e_424d, 2);  jmp(0x100e_4255, 6); goto l_0x100e_4255;/* jmp 0x100e4255 */
        l_0x100e_424f:
            ii(0x100e_424f, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_4252, 3);  inc(memd[ss, ebp - 16]);              /* inc dword [ebp-0x10] */
        l_0x100e_4255:
            ii(0x100e_4255, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_4258, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100e_425b, 4);  cmp(ax, memw[ds, edx + 40]);          /* cmp ax, [edx+0x28] */
            ii(0x100e_425f, 2);  if(jge(0x100e_42b5, 0x54)) goto l_0x100e_42b5;/* jge 0x100e42b5 */
            ii(0x100e_4261, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_4263, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100e_4266, 5);  call(0x1013_ad11, 0x5_6aa6);          /* call 0x1013ad11 */
            ii(0x100e_426b, 2);  test(al, al);                         /* test al, al */
            ii(0x100e_426d, 2);  if(jz(0x100e_428a, 0x1b)) goto l_0x100e_428a;/* jz 0x100e428a */
            ii(0x100e_426f, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100e_4271, 3);  mov(bl, memb[ss, ebp - 4]);           /* mov bl, [ebp-0x4] */
            ii(0x100e_4274, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_4276, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100e_427a, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100e_427d, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x100e_4280, 3);  mov(eax, memd[ds, eax + 44]);         /* mov eax, [eax+0x2c] */
            ii(0x100e_4283, 5);  call(0x100e_15b6, -0x2cd2);           /* call 0x100e15b6 */
            ii(0x100e_4288, 2);  jmp(0x100e_42b3, 0x29); goto l_0x100e_42b3;/* jmp 0x100e42b3 */
        l_0x100e_428a:
            ii(0x100e_428a, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100e_428c, 3);  mov(bl, memb[ss, ebp - 4]);           /* mov bl, [ebp-0x4] */
            ii(0x100e_428f, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100e_4292, 5);  call(0x1007_63d4, -0x6_dec3);         /* call 0x100763d4 */
            ii(0x100e_4297, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100e_4299, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100e_429d, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100e_42a0, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x100e_42a3, 3);  mov(eax, memd[ds, eax + 44]);         /* mov eax, [eax+0x2c] */
            ii(0x100e_42a6, 5);  call(0x100e_15b6, -0x2cf5);           /* call 0x100e15b6 */
            ii(0x100e_42ab, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100e_42ae, 5);  call(0x1007_6bf8, -0x6_d6bb);         /* call 0x10076bf8 */
        l_0x100e_42b3:
            ii(0x100e_42b3, 2);  jmp(0x100e_424f, -0x66); goto l_0x100e_424f;/* jmp 0x100e424f */
        l_0x100e_42b5:
            ii(0x100e_42b5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_42b8, 3);  mov(eax, memd[ds, eax + 40]);         /* mov eax, [eax+0x28] */
            ii(0x100e_42bb, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100e_42be, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100e_42c0, 2);  if(jle(0x100e_42cf, 0xd)) goto l_0x100e_42cf;/* jle 0x100e42cf */
            ii(0x100e_42c2, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_42c4, 3);  mov(dl, memb[ss, ebp - 4]);           /* mov dl, [ebp-0x4] */
            ii(0x100e_42c7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_42ca, 5);  call(0x100e_3e05, -0x4ca);            /* call 0x100e3e05 */
        l_0x100e_42cf:
            ii(0x100e_42cf, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_42d1, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100e_42d4, 5);  call(0x1007_5f6c, -0x6_e36d);         /* call 0x10075f6c */
            ii(0x100e_42d9, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_42db, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_42dc, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_42dd, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_42de, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_42df, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_42e0, 1);  ret();                                /* ret */
        }
    }
}
