using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_5d74-354f138c")]
        public void /* sys */ Method_1018_5d74()
        {
            ii(0x1018_5d74, 1);  push(ebx);                            /* push ebx */
            ii(0x1018_5d75, 1);  push(ecx);                            /* push ecx */
            ii(0x1018_5d76, 1);  push(esi);                            /* push esi */
            ii(0x1018_5d77, 1);  push(edi);                            /* push edi */
            ii(0x1018_5d78, 1);  push(ebp);                            /* push ebp */
            ii(0x1018_5d79, 3);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1018_5d7c, 2);  mov(ebp, eax);                        /* mov ebp, eax */
            ii(0x1018_5d7e, 2);  mov(edi, edx);                        /* mov edi, edx */
            ii(0x1018_5d80, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1018_5d82, 3);  mov(memd[ss, esp], edx);              /* mov [esp], edx */
            ii(0x1018_5d85, 2);  mov(ecx, memd[ds, eax]);              /* mov ecx, [eax] */
            ii(0x1018_5d87, 2);  mov(ebx, esp);                        /* mov ebx, esp */
            ii(0x1018_5d89, 2);  test(ecx, ecx);                       /* test ecx, ecx */
            ii(0x1018_5d8b, 2);  if(jz(0x1018_5dbf, 0x32)) goto l_0x1018_5dbf;/* jz 0x10185dbf */
        l_0x1018_5d8d:
            ii(0x1018_5d8d, 2);  mov(edx, edi);                        /* mov edx, edi */
            ii(0x1018_5d8f, 2);  mov(eax, ecx);                        /* mov eax, ecx */
            ii(0x1018_5d91, 3);  mov(esi, memd[ds, ecx + 16]);         /* mov esi, [ecx+0x10] */
            ii(0x1018_5d94, 5);  call(/* sys */ 0x1018_5dd0, 0x37);    /* call 0x10185dd0 */
            ii(0x1018_5d99, 2);  mov(memd[ds, ebx], eax);              /* mov [ebx], eax */
            ii(0x1018_5d9b, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1018_5d9d, 2);  if(jz(0x1018_5dab, 0xc)) goto l_0x1018_5dab;/* jz 0x10185dab */
        l_0x1018_5d9f:
            ii(0x1018_5d9f, 2);  mov(ebx, memd[ds, ebx]);              /* mov ebx, [ebx] */
            ii(0x1018_5da1, 3);  mov(edx, memd[ds, ebx + 16]);         /* mov edx, [ebx+0x10] */
            ii(0x1018_5da4, 3);  add(ebx, 0x10);                       /* add ebx, 0x10 */
            ii(0x1018_5da7, 2);  test(edx, edx);                       /* test edx, edx */
            ii(0x1018_5da9, 2);  if(jnz(0x1018_5d9f, -0xc)) goto l_0x1018_5d9f;/* jnz 0x10185d9f */
        l_0x1018_5dab:
            ii(0x1018_5dab, 5);  mov(eax, memd[ds, 0x101b_e850]);      /* mov eax, [0x101be850] */
            ii(0x1018_5db0, 6);  mov(memd[ds, 0x101b_e850], ecx);      /* mov [0x101be850], ecx */
            ii(0x1018_5db6, 3);  mov(memd[ds, ecx + 16], eax);         /* mov [ecx+0x10], eax */
            ii(0x1018_5db9, 2);  mov(ecx, esi);                        /* mov ecx, esi */
            ii(0x1018_5dbb, 2);  test(esi, esi);                       /* test esi, esi */
            ii(0x1018_5dbd, 2);  if(jnz(0x1018_5d8d, -0x32)) goto l_0x1018_5d8d;/* jnz 0x10185d8d */
        l_0x1018_5dbf:
            ii(0x1018_5dbf, 3);  mov(eax, memd[ss, esp]);              /* mov eax, [esp] */
            ii(0x1018_5dc2, 3);  mov(memd[ss, ebp], eax);              /* mov [ebp], eax */
            ii(0x1018_5dc5, 3);  add(esp, 4);                          /* add esp, 0x4 */
            ii(0x1018_5dc8, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1018_5dc9, 1);  pop(edi);                             /* pop edi */
            ii(0x1018_5dca, 1);  pop(esi);                             /* pop esi */
            ii(0x1018_5dcb, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1018_5dcc, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1018_5dcd, 1);  ret();                                /* ret */
        }
    }
}
