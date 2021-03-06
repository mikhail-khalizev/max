using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_4dd0-6650ea2a")]
        public void /* sys */ Method_1018_4dd0()
        {
            ii(0x1018_4dd0, 1);  push(ebx);                            /* push ebx */
            ii(0x1018_4dd1, 1);  push(ecx);                            /* push ecx */
            ii(0x1018_4dd2, 1);  push(esi);                            /* push esi */
            ii(0x1018_4dd3, 1);  push(edi);                            /* push edi */
            ii(0x1018_4dd4, 1);  push(ebp);                            /* push ebp */
            ii(0x1018_4dd5, 3);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x1018_4dd8, 2);  mov(ebp, eax);                        /* mov ebp, eax */
            ii(0x1018_4dda, 2);  mov(edi, edx);                        /* mov edi, edx */
            ii(0x1018_4ddc, 7);  cmp(memd[ds, 0x101b_e848], 0);        /* cmp dword [0x101be848], 0x0 */
            ii(0x1018_4de3, 2);  if(jz(0x1018_4def, 0xa)) goto l_0x1018_4def;/* jz 0x10184def */
            ii(0x1018_4de5, 5);  mov(eax, 0xffff_ffff);                /* mov eax, 0xffffffff */
            ii(0x1018_4dea, 5);  jmp(0x1018_4e87, 0x98); goto l_0x1018_4e87;/* jmp 0x10184e87 */
        l_0x1018_4def:
            ii(0x1018_4def, 5);  mov(memd[ds, 0x101b_e848], eax);      /* mov [0x101be848], eax */
            ii(0x1018_4df4, 3);  add(eax, 0x18);                       /* add eax, 0x18 */
            ii(0x1018_4df7, 4);  mov(memd[ss, esp + 16], eax);         /* mov [esp+0x10], eax */
        l_0x1018_4dfb:
            ii(0x1018_4dfb, 3);  imul(esi, edi, 0x24);                 /* imul esi, edi, 0x24 */
            ii(0x1018_4dfe, 4);  mov(ebx, memd[ss, esp + 16]);         /* mov ebx, [esp+0x10] */
            ii(0x1018_4e02, 2);  mov(eax, esp);                        /* mov eax, esp */
            ii(0x1018_4e04, 2);  add(esi, ebx);                        /* add esi, ebx */
            ii(0x1018_4e06, 1);  push(eax);                            /* push eax */
            ii(0x1018_4e07, 3);  mov(ecx, memd[ds, esi + 32]);         /* mov ecx, [esi+0x20] */
            ii(0x1018_4e0a, 3);  mov(eax, memd[ds, esi + 28]);         /* mov eax, [esi+0x1c] */
            ii(0x1018_4e0d, 2);  mov(ebx, memd[ds, esi]);              /* mov ebx, [esi] */
            ii(0x1018_4e0f, 1);  push(ecx);                            /* push ecx */
            ii(0x1018_4e10, 3);  mov(edx, memd[ds, esi + 20]);         /* mov edx, [esi+0x14] */
            ii(0x1018_4e13, 3);  mov(ecx, memd[ss, ebp + 16]);         /* mov ecx, [ebp+0x10] */
            ii(0x1018_4e16, 1);  push(eax);                            /* push eax */
            ii(0x1018_4e17, 1);  inc(ecx);                             /* inc ecx */
            ii(0x1018_4e18, 3);  mov(eax, memd[ds, esi + 24]);         /* mov eax, [esi+0x18] */
            ii(0x1018_4e1b, 5);  call(/* sys */ 0x1018_40d4, -0xd4c);  /* call 0x101840d4 */
            ii(0x1018_4e20, 3);  cmp(eax, -1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1018_4e23, 2);  if(jnz(0x1018_4e36, 0x11)) goto l_0x1018_4e36;/* jnz 0x10184e36 */
            ii(0x1018_4e25, 2);  xor(esi, esi);                        /* xor esi, esi */
            ii(0x1018_4e27, 6);  mov(memd[ds, 0x101b_e848], esi);      /* mov [0x101be848], esi */
            ii(0x1018_4e2d, 3);  add(esp, 0x14);                       /* add esp, 0x14 */
            ii(0x1018_4e30, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1018_4e31, 1);  pop(edi);                             /* pop edi */
            ii(0x1018_4e32, 1);  pop(esi);                             /* pop esi */
            ii(0x1018_4e33, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1018_4e34, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1018_4e35, 1);  ret(); return;                        /* ret */
        l_0x1018_4e36:
            ii(0x1018_4e36, 1);  push(edi);                            /* push edi */
            ii(0x1018_4e37, 1);  push(ebp);                            /* push ebp */
            ii(0x1018_4e38, 3);  mov(edx, memd[ds, esi + 32]);         /* mov edx, [esi+0x20] */
            ii(0x1018_4e3b, 1);  push(edx);                            /* push edx */
            ii(0x1018_4e3c, 3);  mov(ebx, memd[ds, esi + 28]);         /* mov ebx, [esi+0x1c] */
            ii(0x1018_4e3f, 3);  mov(ecx, memd[ds, esi + 20]);         /* mov ecx, [esi+0x14] */
            ii(0x1018_4e42, 1);  push(ebx);                            /* push ebx */
            ii(0x1018_4e43, 4);  lea(edx, memd[ss, esp + 16]);         /* lea edx, [esp+0x10] */
            ii(0x1018_4e47, 3);  mov(ebx, memd[ds, esi + 24]);         /* mov ebx, [esi+0x18] */
            ii(0x1018_4e4a, 5);  call(/* sys */ 0x1018_41a4, -0xcab);  /* call 0x101841a4 */
            ii(0x1018_4e4f, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1018_4e51, 3);  cmp(eax, -1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1018_4e54, 2);  if(jge(0x1018_4e5d, 7)) goto l_0x1018_4e5d;/* jge 0x10184e5d */
            ii(0x1018_4e56, 5);  mov(edi, 0xffff_fffe);                /* mov edi, 0xfffffffe */
            ii(0x1018_4e5b, 2);  sub(edi, eax);                        /* sub edi, eax */
        l_0x1018_4e5d:
            ii(0x1018_4e5d, 3);  cmp(edx, -1 /* 0xff */);              /* cmp edx, 0xffffffff */
            ii(0x1018_4e60, 2);  if(jl(0x1018_4dfb, -0x67)) goto l_0x1018_4dfb;/* jl 0x10184dfb */
            ii(0x1018_4e62, 2);  if(jz(0x1018_4e7d, 0x19)) goto l_0x1018_4e7d;/* jz 0x10184e7d */
            ii(0x1018_4e64, 5);  call(/* sys */ 0x1016_b378, -0x1_9af1);/* call 0x1016b378 */
            ii(0x1018_4e69, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1018_4e6b, 5);  call(/* sys */ 0x1016_b280, -0x1_9bf0);/* call 0x1016b280 */
            ii(0x1018_4e70, 7);  lea(eax, memd[ds, edi * 8]);          /* lea eax, [edi*8] */
            ii(0x1018_4e77, 2);  add(eax, edi);                        /* add eax, edi */
            ii(0x1018_4e79, 4);  mov(edx, memd[ss, ebp + eax * 4 + 40]);/* mov edx, [ebp+eax*4+0x28] */
        l_0x1018_4e7d:
            ii(0x1018_4e7d, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
            ii(0x1018_4e7f, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1018_4e81, 6);  mov(memd[ds, 0x101b_e848], ecx);      /* mov [0x101be848], ecx */
        l_0x1018_4e87:
            ii(0x1018_4e87, 3);  add(esp, 0x14);                       /* add esp, 0x14 */
            ii(0x1018_4e8a, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1018_4e8b, 1);  pop(edi);                             /* pop edi */
            ii(0x1018_4e8c, 1);  pop(esi);                             /* pop esi */
            ii(0x1018_4e8d, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1018_4e8e, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1018_4e8f, 1);  ret();                                /* ret */
        }
    }
}
