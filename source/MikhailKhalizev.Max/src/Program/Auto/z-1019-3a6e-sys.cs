using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_3a6e-6be9c73d")]
        public void /* sys */ Method_1019_3a6e()
        {
            ii(0x1019_3a6e, 1);  push(ebx);                            /* push ebx */
            ii(0x1019_3a6f, 1);  push(ecx);                            /* push ecx */
            ii(0x1019_3a70, 1);  push(edx);                            /* push edx */
            ii(0x1019_3a71, 1);  push(esi);                            /* push esi */
            ii(0x1019_3a72, 1);  push(edi);                            /* push edi */
            ii(0x1019_3a73, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x1019_3a75, 3);  shl(ecx, 2);                          /* shl ecx, 0x2 */
            ii(0x1019_3a78, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1019_3a7b, 2);  sub(ebx, ecx);                        /* sub ebx, ecx */
            ii(0x1019_3a7d, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1019_3a80, 2);  sub(edx, ecx);                        /* sub edx, ecx */
            ii(0x1019_3a82, 6);  sub(ecx, memd[ds, Definitions.video_win_end]);/* sub ecx, [0x10209cac] */
            ii(0x1019_3a88, 2);  neg(ecx);                             /* neg ecx */
            ii(0x1019_3a8a, 3);  mov(memd[ss, ebp - 44], ecx);         /* mov [ebp-0x2c], ecx */
            ii(0x1019_3a8d, 3);  cmp(edi, memd[ss, ebp - 44]);         /* cmp edi, [ebp-0x2c] */
            ii(0x1019_3a90, 2);  if(jns(0x1019_3af1, 0x5f)) goto l_0x1019_3af1;/* jns 0x10193af1 */
            ii(0x1019_3a92, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x1019_3a94, 2);  rep(() => movsd());                   /* rep movsd */
            ii(0x1019_3a96, 2);  add(esi, ebx);                        /* add esi, ebx */
            ii(0x1019_3a98, 2);  add(edi, edx);                        /* add edi, edx */
            ii(0x1019_3a9a, 3);  cmp(edi, memd[ss, ebp - 44]);         /* cmp edi, [ebp-0x2c] */
            ii(0x1019_3a9d, 2);  if(jns(0x1019_3af1, 0x52)) goto l_0x1019_3af1;/* jns 0x10193af1 */
            ii(0x1019_3a9f, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x1019_3aa1, 2);  rep(() => movsd());                   /* rep movsd */
            ii(0x1019_3aa3, 2);  add(esi, ebx);                        /* add esi, ebx */
            ii(0x1019_3aa5, 2);  add(edi, edx);                        /* add edi, edx */
            ii(0x1019_3aa7, 3);  cmp(edi, memd[ss, ebp - 44]);         /* cmp edi, [ebp-0x2c] */
            ii(0x1019_3aaa, 2);  if(jns(0x1019_3af1, 0x45)) goto l_0x1019_3af1;/* jns 0x10193af1 */
            ii(0x1019_3aac, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x1019_3aae, 2);  rep(() => movsd());                   /* rep movsd */
            ii(0x1019_3ab0, 2);  add(esi, ebx);                        /* add esi, ebx */
            ii(0x1019_3ab2, 2);  add(edi, edx);                        /* add edi, edx */
            ii(0x1019_3ab4, 3);  cmp(edi, memd[ss, ebp - 44]);         /* cmp edi, [ebp-0x2c] */
            ii(0x1019_3ab7, 2);  if(jns(0x1019_3af1, 0x38)) goto l_0x1019_3af1;/* jns 0x10193af1 */
            ii(0x1019_3ab9, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x1019_3abb, 2);  rep(() => movsd());                   /* rep movsd */
            ii(0x1019_3abd, 2);  add(esi, ebx);                        /* add esi, ebx */
            ii(0x1019_3abf, 2);  add(edi, edx);                        /* add edi, edx */
            ii(0x1019_3ac1, 3);  cmp(edi, memd[ss, ebp - 44]);         /* cmp edi, [ebp-0x2c] */
            ii(0x1019_3ac4, 2);  if(jns(0x1019_3af1, 0x2b)) goto l_0x1019_3af1;/* jns 0x10193af1 */
            ii(0x1019_3ac6, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x1019_3ac8, 2);  rep(() => movsd());                   /* rep movsd */
            ii(0x1019_3aca, 2);  add(esi, ebx);                        /* add esi, ebx */
            ii(0x1019_3acc, 2);  add(edi, edx);                        /* add edi, edx */
            ii(0x1019_3ace, 3);  cmp(edi, memd[ss, ebp - 44]);         /* cmp edi, [ebp-0x2c] */
            ii(0x1019_3ad1, 2);  if(jns(0x1019_3af1, 0x1e)) goto l_0x1019_3af1;/* jns 0x10193af1 */
            ii(0x1019_3ad3, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x1019_3ad5, 2);  rep(() => movsd());                   /* rep movsd */
            ii(0x1019_3ad7, 2);  add(esi, ebx);                        /* add esi, ebx */
            ii(0x1019_3ad9, 2);  add(edi, edx);                        /* add edi, edx */
            ii(0x1019_3adb, 3);  cmp(edi, memd[ss, ebp - 44]);         /* cmp edi, [ebp-0x2c] */
            ii(0x1019_3ade, 2);  if(jns(0x1019_3af1, 0x11)) goto l_0x1019_3af1;/* jns 0x10193af1 */
            ii(0x1019_3ae0, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x1019_3ae2, 2);  rep(() => movsd());                   /* rep movsd */
            ii(0x1019_3ae4, 2);  add(esi, ebx);                        /* add esi, ebx */
            ii(0x1019_3ae6, 2);  add(edi, edx);                        /* add edi, edx */
            ii(0x1019_3ae8, 3);  cmp(edi, memd[ss, ebp - 44]);         /* cmp edi, [ebp-0x2c] */
            ii(0x1019_3aeb, 2);  if(jns(0x1019_3af1, 4)) goto l_0x1019_3af1;/* jns 0x10193af1 */
            ii(0x1019_3aed, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x1019_3aef, 2);  jmp(0x1019_3afe, 0xd); goto l_0x1019_3afe;/* jmp 0x10193afe */
        l_0x1019_3af1:
            ii(0x1019_3af1, 6);  mov(ecx, memd[ds, Definitions.video_win_end]);/* mov ecx, [0x10209cac] */
            ii(0x1019_3af7, 2);  sub(ecx, edi);                        /* sub ecx, edi */
            ii(0x1019_3af9, 2);  if(js(0x1019_3b00, 5)) goto l_0x1019_3b00;/* js 0x10193b00 */
            ii(0x1019_3afb, 3);  shr(ecx, 2);                          /* shr ecx, 0x2 */
        l_0x1019_3afe:
            ii(0x1019_3afe, 2);  rep(() => movsd());                   /* rep movsd */
        l_0x1019_3b00:
            ii(0x1019_3b00, 1);  pop(edi);                             /* pop edi */
            ii(0x1019_3b01, 1);  pop(esi);                             /* pop esi */
            ii(0x1019_3b02, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x1019_3b04, 3);  shl(ecx, 2);                          /* shl ecx, 0x2 */
            ii(0x1019_3b07, 2);  add(esi, ecx);                        /* add esi, ecx */
            ii(0x1019_3b09, 2);  add(edi, ecx);                        /* add edi, ecx */
            ii(0x1019_3b0b, 1);  pop(edx);                             /* pop edx */
            ii(0x1019_3b0c, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1019_3b0d, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1019_3b0e, 1);  ret();                                /* ret */
        }
    }
}
