using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_70b0-eac1f32e")]
        public void /* sys */ Method_1016_70b0()
        {
            ii(0x1016_70b0, 1);  push(esi);                            /* push esi */
            ii(0x1016_70b1, 1);  push(edi);                            /* push edi */
            ii(0x1016_70b2, 1);  push(ebp);                            /* push ebp */
            ii(0x1016_70b3, 3);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1016_70b6, 4);  mov(esi, memd[ss, esp + 20]);         /* mov esi, [esp+0x14] */
            ii(0x1016_70ba, 5);  call(/* sys */ 0x1016_7dac, 0xced);   /* call 0x10167dac */
            ii(0x1016_70bf, 6);  mov(ebp, memd[ds, 0x101b_ddbc]);      /* mov ebp, [0x101bddbc] */
            ii(0x1016_70c5, 2);  mov(edi, eax);                        /* mov edi, eax */
            ii(0x1016_70c7, 2);  test(ebp, ebp);                       /* test ebp, ebp */
            ii(0x1016_70c9, 2);  if(jz(0x1016_7134, 0x69)) goto l_0x1016_7134;/* jz 0x10167134 */
            ii(0x1016_70cb, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1016_70cd, 2);  if(jz(0x1016_7134, 0x65)) goto l_0x1016_7134;/* jz 0x10167134 */
            ii(0x1016_70cf, 5);  test(memb[ss, esp + 25], 0xff);       /* test byte [esp+0x19], 0xff */
            ii(0x1016_70d4, 2);  if(jz(0x1016_7102, 0x2c)) goto l_0x1016_7102;/* jz 0x10167102 */
            ii(0x1016_70d6, 4);  mov(eax, memd[ss, esp + 24]);         /* mov eax, [esp+0x18] */
            ii(0x1016_70da, 5);  and(eax, 0xffff);                     /* and eax, 0xffff */
            ii(0x1016_70df, 7);  mov(eax, memd[ds, eax * 4 + 0x101b_d9bc]);/* mov eax, [eax*4+0x101bd9bc] */
            ii(0x1016_70e6, 6);  mov(al, memb[ds, eax + 0x1020_0520]); /* mov al, [eax+0x10200520] */
            ii(0x1016_70ec, 4);  mov(ebp, memd[ss, esp + 24]);         /* mov ebp, [esp+0x18] */
            ii(0x1016_70f0, 6);  and(ebp, 0xffff_0000);                /* and ebp, 0xffff0000 */
            ii(0x1016_70f6, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1016_70fb, 2);  or(ebp, eax);                         /* or ebp, eax */
            ii(0x1016_70fd, 3);  mov(memd[ss, esp], ebp);              /* mov [esp], ebp */
            ii(0x1016_7100, 2);  jmp(0x1016_7109, 7); goto l_0x1016_7109;/* jmp 0x10167109 */
        l_0x1016_7102:
            ii(0x1016_7102, 4);  mov(eax, memd[ss, esp + 24]);         /* mov eax, [esp+0x18] */
            ii(0x1016_7106, 3);  mov(memd[ss, esp], eax);              /* mov [esp], eax */
        l_0x1016_7109:
            ii(0x1016_7109, 3);  mov(eax, memd[ss, esp]);              /* mov eax, [esp] */
            ii(0x1016_710c, 2);  cmp(ecx, edx);                        /* cmp ecx, edx */
            ii(0x1016_710e, 2);  if(jge(0x1016_7116, 6)) goto l_0x1016_7116;/* jge 0x10167116 */
            ii(0x1016_7110, 2);  xor(ecx, edx);                        /* xor ecx, edx */
            ii(0x1016_7112, 2);  xor(edx, ecx);                        /* xor edx, ecx */
            ii(0x1016_7114, 2);  xor(ecx, edx);                        /* xor ecx, edx */
        l_0x1016_7116:
            ii(0x1016_7116, 2);  cmp(esi, ebx);                        /* cmp esi, ebx */
            ii(0x1016_7118, 2);  if(jge(0x1016_7120, 6)) goto l_0x1016_7120;/* jge 0x10167120 */
            ii(0x1016_711a, 2);  xor(esi, ebx);                        /* xor esi, ebx */
            ii(0x1016_711c, 2);  xor(ebx, esi);                        /* xor ebx, esi */
            ii(0x1016_711e, 2);  xor(esi, ebx);                        /* xor esi, ebx */
        l_0x1016_7120:
            ii(0x1016_7120, 1);  push(eax);                            /* push eax */
            ii(0x1016_7121, 1);  push(esi);                            /* push esi */
            ii(0x1016_7122, 3);  mov(eax, memd[ds, edi + 44]);         /* mov eax, [edi+0x2c] */
            ii(0x1016_7125, 1);  push(ecx);                            /* push ecx */
            ii(0x1016_7126, 3);  mov(esi, memd[ds, edi + 24]);         /* mov esi, [edi+0x18] */
            ii(0x1016_7129, 2);  mov(ecx, ebx);                        /* mov ecx, ebx */
            ii(0x1016_712b, 2);  mov(ebx, edx);                        /* mov ebx, edx */
            ii(0x1016_712d, 2);  mov(edx, esi);                        /* mov edx, esi */
            ii(0x1016_712f, 5);  call(/* sys */ 0x1016_a68c, 0x3558);  /* call 0x1016a68c */
        l_0x1016_7134:
            ii(0x1016_7134, 3);  add(esp, 4);                          /* add esp, 0x4 */
            ii(0x1016_7137, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1016_7138, 1);  pop(edi);                             /* pop edi */
            ii(0x1016_7139, 1);  pop(esi);                             /* pop esi */
            ii(0x1016_713a, 3);  ret(8);                               /* ret 0x8 */
        }
    }
}
