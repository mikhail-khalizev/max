using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_6990-5106ccb7")]
        public void /* sys */ Method_1016_6990()
        {
            ii(0x1016_6990, 1);  push(ebx);                            /* push ebx */
            ii(0x1016_6991, 1);  push(ecx);                            /* push ecx */
            ii(0x1016_6992, 1);  push(edx);                            /* push edx */
            ii(0x1016_6993, 1);  push(esi);                            /* push esi */
            ii(0x1016_6994, 1);  push(edi);                            /* push edi */
            ii(0x1016_6995, 3);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1016_6998, 6);  mov(ecx, memd[ds, 0x101c_b2d8]);      /* mov ecx, [0x101cb2d8] */
            ii(0x1016_699e, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1016_69a0, 5);  call(/* sys */ 0x1016_7dac, 0x1407);  /* call 0x10167dac */
            ii(0x1016_69a5, 7);  cmp(memd[ds, 0x101b_ddbc], 0);        /* cmp dword [0x101bddbc], 0x0 */
            ii(0x1016_69ac, 6);  if(jz(0x1016_6a25, 0x73)) goto l_0x1016_6a25;/* jz 0x10166a25 */
            ii(0x1016_69b2, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1016_69b4, 2);  if(jz(0x1016_6a25, 0x6f)) goto l_0x1016_6a25;/* jz 0x10166a25 */
            ii(0x1016_69b6, 2);  mov(edi, esp);                        /* mov edi, esp */
            ii(0x1016_69b8, 3);  lea(esi, memd[ds, eax + 8]);          /* lea esi, [eax+0x8] */
            ii(0x1016_69bb, 1);  movsd();                              /* movsd */
            ii(0x1016_69bc, 1);  movsd();                              /* movsd */
            ii(0x1016_69bd, 1);  movsd();                              /* movsd */
            ii(0x1016_69be, 1);  movsd();                              /* movsd */
            ii(0x1016_69bf, 2);  mov(ebx, memd[ds, eax]);              /* mov ebx, [eax] */
            ii(0x1016_69c1, 5);  mov(esi, 0xffff_ffff);                /* mov esi, 0xffffffff */
            ii(0x1016_69c6, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1016_69c8, 7);  mov(ebx, memd[ds, ebx * 4 + 0x101c_b134]);/* mov ebx, [ebx*4+0x101cb134] */
            ii(0x1016_69cf, 5);  call(/* sys */ 0x1016_6a34, 0x60);    /* call 0x10166a34 */
            ii(0x1016_69d4, 6);  mov(ecx, memd[ds, 0x101c_b2d8]);      /* mov ecx, [0x101cb2d8] */
            ii(0x1016_69da, 7);  mov(memd[ds, edx * 4 + 0x101c_b134], esi);/* mov [edx*4+0x101cb134], esi */
            ii(0x1016_69e1, 1);  dec(ecx);                             /* dec ecx */
            ii(0x1016_69e2, 2);  mov(edx, ebx);                        /* mov edx, ebx */
            ii(0x1016_69e4, 2);  cmp(ebx, ecx);                        /* cmp ebx, ecx */
            ii(0x1016_69e6, 2);  if(jge(0x1016_6a0c, 0x24)) goto l_0x1016_6a0c;/* jge 0x10166a0c */
            ii(0x1016_69e8, 7);  lea(eax, memd[ds, ebx * 4]);          /* lea eax, [ebx*4] */
        l_0x1016_69ef:
            ii(0x1016_69ef, 6);  mov(ebx, memd[ds, eax + 0x101c_b200]);/* mov ebx, [eax+0x101cb200] */
            ii(0x1016_69f5, 6);  mov(memd[ds, eax + 0x101c_b1fc], ebx);/* mov [eax+0x101cb1fc], ebx */
            ii(0x1016_69fb, 2);  mov(ebx, memd[ds, ebx]);              /* mov ebx, [ebx] */
            ii(0x1016_69fd, 7);  mov(memd[ds, ebx * 4 + 0x101c_b134], edx);/* mov [ebx*4+0x101cb134], edx */
            ii(0x1016_6a04, 1);  inc(edx);                             /* inc edx */
            ii(0x1016_6a05, 3);  add(eax, 4);                          /* add eax, 0x4 */
            ii(0x1016_6a08, 2);  cmp(edx, ecx);                        /* cmp edx, ecx */
            ii(0x1016_6a0a, 2);  if(jl(0x1016_69ef, -0x1d)) goto l_0x1016_69ef;/* jl 0x101669ef */
        l_0x1016_6a0c:
            ii(0x1016_6a0c, 6);  mov(edi, memd[ds, 0x101b_ddbc]);      /* mov edi, [0x101bddbc] */
            ii(0x1016_6a12, 6);  mov(memd[ds, 0x101c_b2d8], ecx);      /* mov [0x101cb2d8], ecx */
            ii(0x1016_6a18, 2);  test(edi, edi);                       /* test edi, edi */
            ii(0x1016_6a1a, 2);  if(jz(0x1016_6a25, 9)) goto l_0x1016_6a25;/* jz 0x10166a25 */
            ii(0x1016_6a1c, 2);  mov(eax, esp);                        /* mov eax, esp */
            ii(0x1016_6a1e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1016_6a20, 5);  call(/* sys */ 0x1016_7d38, 0x1313);  /* call 0x10167d38 */
        l_0x1016_6a25:
            ii(0x1016_6a25, 6);  mov(ecx, memd[ds, 0x101c_b2d8]);      /* mov ecx, [0x101cb2d8] */
            ii(0x1016_6a2b, 3);  add(esp, 0x10);                       /* add esp, 0x10 */
            ii(0x1016_6a2e, 1);  pop(edi);                             /* pop edi */
            ii(0x1016_6a2f, 1);  pop(esi);                             /* pop esi */
            ii(0x1016_6a30, 1);  pop(edx);                             /* pop edx */
            ii(0x1016_6a31, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1016_6a32, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1016_6a33, 1);  ret();                                /* ret */
        }
    }
}
