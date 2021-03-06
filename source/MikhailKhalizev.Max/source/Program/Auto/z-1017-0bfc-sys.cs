using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_0bfc-f8da7b66")]
        public void /* sys */ Method_1017_0bfc()
        {
            ii(0x1017_0bfc, 1);  push(ebx);                            /* push ebx */
            ii(0x1017_0bfd, 1);  push(ecx);                            /* push ecx */
            ii(0x1017_0bfe, 1);  push(edx);                            /* push edx */
            ii(0x1017_0bff, 1);  push(edi);                            /* push edi */
            ii(0x1017_0c00, 1);  push(ebp);                            /* push ebp */
            ii(0x1017_0c01, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x1017_0c03, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1017_0c05, 6);  if(jz(0x1017_0c86, 0x7b)) goto l_0x1017_0c86;/* jz 0x10170c86 */
            ii(0x1017_0c0b, 3);  mov(edx, memd[ds, eax + 4]);          /* mov edx, [eax+0x4] */
            ii(0x1017_0c0e, 2);  test(edx, edx);                       /* test edx, edx */
            ii(0x1017_0c10, 2);  if(jz(0x1017_0c20, 0xe)) goto l_0x1017_0c20;/* jz 0x10170c20 */
            ii(0x1017_0c12, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1017_0c14, 5);  call(Definitions.sys_fclose, 0x1450); /* call 0x10172069 */
            ii(0x1017_0c19, 7);  mov(memd[ds, ecx + 4], 0);            /* mov dword [ecx+0x4], 0x0 */
        l_0x1017_0c20:
            ii(0x1017_0c20, 2);  mov(ebx, memd[ds, ecx]);              /* mov ebx, [ecx] */
            ii(0x1017_0c22, 2);  test(ebx, ebx);                       /* test ebx, ebx */
            ii(0x1017_0c24, 2);  if(jz(0x1017_0c34, 0xe)) goto l_0x1017_0c34;/* jz 0x10170c34 */
            ii(0x1017_0c26, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1017_0c28, 6);  call_abs(memd[ds, 0x101b_e1d0]);      /* call dword [0x101be1d0] */ /* Вызов '0x1017_11b4'. */
            ii(0x1017_0c2e, 6);  mov(memd[ds, ecx], 0);                /* mov dword [ecx], 0x0 */
        l_0x1017_0c34:
            ii(0x1017_0c34, 4);  cmp(memd[ds, ecx + 56], 0);           /* cmp dword [ecx+0x38], 0x0 */
            ii(0x1017_0c38, 2);  if(jz(0x1017_0c6a, 0x30)) goto l_0x1017_0c6a;/* jz 0x10170c6a */
            ii(0x1017_0c3a, 3);  mov(edi, memd[ds, ecx + 24]);         /* mov edi, [ecx+0x18] */
            ii(0x1017_0c3d, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1017_0c3f, 2);  test(edi, edi);                       /* test edi, edi */
            ii(0x1017_0c41, 2);  if(jle(0x1017_0c5a, 0x17)) goto l_0x1017_0c5a;/* jle 0x10170c5a */
            ii(0x1017_0c43, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
        l_0x1017_0c45:
            ii(0x1017_0c45, 3);  mov(eax, memd[ds, ecx + 56]);         /* mov eax, [ecx+0x38] */
            ii(0x1017_0c48, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x1017_0c4a, 1);  inc(edx);                             /* inc edx */
            ii(0x1017_0c4b, 5);  call(/* sys */ 0x1018_b664, 0x1_aa14);/* call 0x1018b664 */
            ii(0x1017_0c50, 3);  mov(ebp, memd[ds, ecx + 24]);         /* mov ebp, [ecx+0x18] */
            ii(0x1017_0c53, 3);  add(ebx, 0x24);                       /* add ebx, 0x24 */
            ii(0x1017_0c56, 2);  cmp(edx, ebp);                        /* cmp edx, ebp */
            ii(0x1017_0c58, 2);  if(jl(0x1017_0c45, -0x15)) goto l_0x1017_0c45;/* jl 0x10170c45 */
        l_0x1017_0c5a:
            ii(0x1017_0c5a, 3);  mov(eax, memd[ds, ecx + 56]);         /* mov eax, [ecx+0x38] */
            ii(0x1017_0c5d, 6);  call_abs(memd[ds, 0x101b_e1d0]);      /* call dword [0x101be1d0] */ /* Вызов '0x1017_11b4'. */
            ii(0x1017_0c63, 7);  mov(memd[ds, ecx + 56], 0);           /* mov dword [ecx+0x38], 0x0 */
        l_0x1017_0c6a:
            ii(0x1017_0c6a, 3);  lea(eax, memd[ds, ecx + 20]);         /* lea eax, [ecx+0x14] */
            ii(0x1017_0c6d, 5);  call(/* sys */ 0x1018_b664, 0x1_a9f2);/* call 0x1018b664 */
            ii(0x1017_0c72, 3);  mov(eax, memd[ds, ecx + 8]);          /* mov eax, [ecx+0x8] */
            ii(0x1017_0c75, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1017_0c77, 2);  if(jz(0x1017_0c86, 0xd)) goto l_0x1017_0c86;/* jz 0x10170c86 */
            ii(0x1017_0c79, 6);  call_abs(memd[ds, 0x101b_e1d0]);      /* call dword [0x101be1d0] */ /* Вызов '0x1017_11b4'. */
            ii(0x1017_0c7f, 7);  mov(memd[ds, ecx + 8], 0);            /* mov dword [ecx+0x8], 0x0 */
        l_0x1017_0c86:
            ii(0x1017_0c86, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1017_0c87, 1);  pop(edi);                             /* pop edi */
            ii(0x1017_0c88, 1);  pop(edx);                             /* pop edx */
            ii(0x1017_0c89, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1017_0c8a, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1017_0c8b, 1);  ret();                                /* ret */
        }
    }
}
