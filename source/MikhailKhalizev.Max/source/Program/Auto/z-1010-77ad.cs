using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_77ad-11790116")]
        public void Method_1010_77ad()
        {
            ii(0x1010_77ad, 5);  push(0x54);                           /* push 0x54 */
            ii(0x1010_77b2, 5);  call(Definitions.sys_check_available_stack_size, 0x5_e59b);/* call 0x10165d52 */
            ii(0x1010_77b7, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_77b8, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_77b9, 1);  push(edx);                            /* push edx */
            ii(0x1010_77ba, 1);  push(esi);                            /* push esi */
            ii(0x1010_77bb, 1);  push(edi);                            /* push edi */
            ii(0x1010_77bc, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_77bd, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_77bf, 6);  sub(esp, 0x38);                       /* sub esp, 0x38 */
            ii(0x1010_77c5, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_77c8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_77cb, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1010_77cd, 3);  mov(bl, memb[ds, eax + 72]);          /* mov bl, [eax+0x48] */
            ii(0x1010_77d0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_77d3, 4);  mov(ax, memw[ds, eax + 40]);          /* mov ax, [eax+0x28] */
            ii(0x1010_77d7, 3);  sub(eax, 0x26);                       /* sub eax, 0x26 */
            ii(0x1010_77da, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_77dc, 3);  mov(dx, ax);                          /* mov dx, ax */
            ii(0x1010_77df, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_77e2, 3);  add(eax, 0x50);                       /* add eax, 0x50 */
            ii(0x1010_77e5, 5);  call(0x1010_7020, -0x7ca);            /* call 0x10107020 */
            ii(0x1010_77ea, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1010_77ec, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_77ef, 4);  mov(memw[ds, eax + 78], dx);          /* mov [eax+0x4e], dx */
        l_0x1010_77f3:
            ii(0x1010_77f3, 5);  call(0x1014_82f4, 0x4_0afc);          /* call 0x101482f4 */
            ii(0x1010_77f8, 6);  sub(eax, memd[ds, 0x101c_4dc8]);      /* sub eax, [0x101c4dc8] */
            ii(0x1010_77fe, 5);  cmp(eax, 0x4a9);                      /* cmp eax, 0x4a9 */
            ii(0x1010_7803, 2);  if(jb(0x1010_77f3, -0x12)) goto l_0x1010_77f3;/* jb 0x101077f3 */
            ii(0x1010_7805, 5);  mov(ebx, 0x32);                       /* mov ebx, 0x32 */
            ii(0x1010_780a, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_780c, 3);  lea(eax, memd[ss, ebp - 56]);         /* lea eax, [ebp-0x38] */
            ii(0x1010_780f, 5);  call(Definitions.sys_memset, 0x5_e5cc);/* call 0x10165de0 */
            ii(0x1010_7814, 7);  mov(memd[ss, ebp - 40], 3);           /* mov dword [ebp-0x28], 0x3 */
            ii(0x1010_781b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_781e, 3);  and(eax, 0xf);                        /* and eax, 0xf */
            ii(0x1010_7821, 3);  mov(memd[ss, ebp - 52], eax);         /* mov [ebp-0x34], eax */
            ii(0x1010_7824, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_7827, 3);  shr(eax, 4);                          /* shr eax, 0x4 */
            ii(0x1010_782a, 5);  and(eax, 0xffff);                     /* and eax, 0xffff */
            ii(0x1010_782f, 4);  mov(memw[ss, ebp - 22], ax);          /* mov [ebp-0x16], ax */
            ii(0x1010_7833, 3);  lea(edx, memd[ss, ebp - 56]);         /* lea edx, [ebp-0x38] */
            ii(0x1010_7836, 5);  mov(eax, 0x7a);                       /* mov eax, 0x7a */
            ii(0x1010_783b, 5);  call(0x100e_44ba, -0x2_3386);         /* call 0x100e44ba */
            ii(0x1010_7840, 5);  call(0x1014_82f4, 0x4_0aaf);          /* call 0x101482f4 */
            ii(0x1010_7845, 5);  mov(memd[ds, 0x101c_4dc8], eax);      /* mov [0x101c4dc8], eax */
            ii(0x1010_784a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_784c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_784d, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_784e, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_784f, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_7850, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_7851, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_7852, 1);  ret();                                /* ret */
        }
    }
}
