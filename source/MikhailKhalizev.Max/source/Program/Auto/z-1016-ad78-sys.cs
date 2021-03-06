using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_ad78-7e49aefe")]
        public void /* sys */ Method_1016_ad78()
        {
            ii(0x1016_ad78, 1);  push(esi);                            /* push esi */
            ii(0x1016_ad79, 1);  push(edi);                            /* push edi */
            ii(0x1016_ad7a, 1);  push(ebp);                            /* push ebp */
            ii(0x1016_ad7b, 3);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1016_ad7e, 2);  mov(esi, eax);                        /* mov esi, eax */
            ii(0x1016_ad80, 3);  mov(memd[ss, esp], edx);              /* mov [esp], edx */
            ii(0x1016_ad83, 4);  mov(memd[ss, esp + 8], ebx);          /* mov [esp+0x8], ebx */
            ii(0x1016_ad87, 4);  mov(memd[ss, esp + 4], ecx);          /* mov [esp+0x4], ecx */
            ii(0x1016_ad8b, 2);  xor(ebp, ebp);                        /* xor ebp, ebp */
            ii(0x1016_ad8d, 2);  test(ebx, ebx);                       /* test ebx, ebx */
            ii(0x1016_ad8f, 2);  if(jle(0x1016_add0, 0x3f)) goto l_0x1016_add0;/* jle 0x1016add0 */
        l_0x1016_ad91:
            ii(0x1016_ad91, 3);  mov(ecx, memd[ss, esp]);              /* mov ecx, [esp] */
            ii(0x1016_ad94, 4);  mov(eax, memd[ss, esp + 28]);         /* mov eax, [esp+0x1c] */
            ii(0x1016_ad98, 2);  mov(edi, esi);                        /* mov edi, esi */
            ii(0x1016_ad9a, 2);  mov(dl, al);                          /* mov dl, al */
            ii(0x1016_ad9c, 2);  xchg(ah, al);                         /* xchg ah, al */
            ii(0x1016_ad9e, 2);  mov(al, dl);                          /* mov al, dl */
            ii(0x1016_ada0, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1016_ada2, 3);  shl(eax, 0x10);                       /* shl eax, 0x10 */
            ii(0x1016_ada5, 2);  or(eax, edx);                         /* or eax, edx */
            ii(0x1016_ada7, 2);  mov(ebx, ecx);                        /* mov ebx, ecx */
            ii(0x1016_ada9, 3);  and(ebx, 3);                          /* and ebx, 0x3 */
            ii(0x1016_adac, 3);  shr(ecx, 2);                          /* shr ecx, 0x2 */
            ii(0x1016_adaf, 2);  test(ecx, ecx);                       /* test ecx, ecx */
            ii(0x1016_adb1, 2);  if(jz(0x1016_adb5, 2)) goto l_0x1016_adb5;/* jz 0x1016adb5 */
            ii(0x1016_adb3, 2);  rep(() => stosd());                   /* rep stosd */
        l_0x1016_adb5:
            ii(0x1016_adb5, 6);  test(ebx, 3);                         /* test ebx, 0x3 */
            ii(0x1016_adbb, 2);  if(jz(0x1016_adc1, 4)) goto l_0x1016_adc1;/* jz 0x1016adc1 */
            ii(0x1016_adbd, 2);  mov(ecx, ebx);                        /* mov ecx, ebx */
            ii(0x1016_adbf, 2);  rep(() => stosb());                   /* rep stosb */
        l_0x1016_adc1:
            ii(0x1016_adc1, 1);  inc(ebp);                             /* inc ebp */
            ii(0x1016_adc2, 4);  mov(ebx, memd[ss, esp + 4]);          /* mov ebx, [esp+0x4] */
            ii(0x1016_adc6, 4);  mov(ecx, memd[ss, esp + 8]);          /* mov ecx, [esp+0x8] */
            ii(0x1016_adca, 2);  add(esi, ebx);                        /* add esi, ebx */
            ii(0x1016_adcc, 2);  cmp(ebp, ecx);                        /* cmp ebp, ecx */
            ii(0x1016_adce, 2);  if(jl(0x1016_ad91, -0x3f)) goto l_0x1016_ad91;/* jl 0x1016ad91 */
        l_0x1016_add0:
            ii(0x1016_add0, 3);  add(esp, 0xc);                        /* add esp, 0xc */
            ii(0x1016_add3, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1016_add4, 1);  pop(edi);                             /* pop edi */
            ii(0x1016_add5, 1);  pop(esi);                             /* pop esi */
            ii(0x1016_add6, 3);  ret(4);                               /* ret 0x4 */
        }
    }
}
