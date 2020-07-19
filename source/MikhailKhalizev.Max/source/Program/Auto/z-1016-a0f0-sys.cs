using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_a0f0-af6a5245")]
        public void /* sys */ Method_1016_a0f0()
        {
            ii(0x1016_a0f0, 1);  push(ebx);                            /* push ebx */
            ii(0x1016_a0f1, 1);  push(ecx);                            /* push ecx */
            ii(0x1016_a0f2, 1);  push(edx);                            /* push edx */
            ii(0x1016_a0f3, 1);  push(esi);                            /* push esi */
            ii(0x1016_a0f4, 1);  push(edi);                            /* push edi */
            ii(0x1016_a0f5, 3);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1016_a0f8, 2);  mov(esi, eax);                        /* mov esi, eax */
            ii(0x1016_a0fa, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1016_a0fc, 2);  if(jz(0x1016_a156, 0x58)) goto l_0x1016_a156;/* jz 0x1016a156 */
            ii(0x1016_a0fe, 7);  cmp(memd[ds, 0x101b_dde8], 0xa);      /* cmp dword [0x101bdde8], 0xa */
            ii(0x1016_a105, 2);  if(jge(0x1016_a156, 0x4f)) goto l_0x1016_a156;/* jge 0x1016a156 */
            ii(0x1016_a107, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1016_a109, 3);  mov(ebx, memd[ds, esi + 4]);          /* mov ebx, [esi+0x4] */
            ii(0x1016_a10c, 2);  cmp(eax, ebx);                        /* cmp eax, ebx */
            ii(0x1016_a10e, 2);  if(jge(0x1016_a156, 0x46)) goto l_0x1016_a156;/* jge 0x1016a156 */
            ii(0x1016_a110, 2);  mov(ecx, memd[ds, esi]);              /* mov ecx, [esi] */
            ii(0x1016_a112, 2);  cmp(ecx, ebx);                        /* cmp ecx, ebx */
            ii(0x1016_a114, 2);  if(jg(0x1016_a129, 0x13)) goto l_0x1016_a129;/* jg 0x1016a129 */
        l_0x1016_a116:
            ii(0x1016_a116, 2);  mov(edx, esp);                        /* mov edx, esp */
            ii(0x1016_a118, 2);  mov(eax, ecx);                        /* mov eax, ecx */
            ii(0x1016_a11a, 5);  call(/* sys */ 0x1016_a2cc, 0x1ad);   /* call 0x1016a2cc */
            ii(0x1016_a11f, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1016_a121, 2);  if(jnz(0x1016_a156, 0x33)) goto l_0x1016_a156;/* jnz 0x1016a156 */
            ii(0x1016_a123, 1);  inc(ecx);                             /* inc ecx */
            ii(0x1016_a124, 3);  cmp(ecx, memd[ds, esi + 4]);          /* cmp ecx, [esi+0x4] */
            ii(0x1016_a127, 2);  if(jle(0x1016_a116, -0x13)) goto l_0x1016_a116;/* jle 0x1016a116 */
        l_0x1016_a129:
            ii(0x1016_a129, 6);  mov(edx, memd[ds, 0x101b_dde8]);      /* mov edx, [0x101bdde8] */
            ii(0x1016_a12f, 7);  lea(eax, memd[ds, edx * 4]);          /* lea eax, [edx*4] */
            ii(0x1016_a136, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1016_a138, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1016_a13b, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1016_a13d, 5);  mov(ecx, 0xb);                        /* mov ecx, 0xb */
            ii(0x1016_a142, 1);  inc(edx);                             /* inc edx */
            ii(0x1016_a143, 7);  lea(edi, memd[ds, eax * 4 + 0x101c_f7ac]);/* lea edi, [eax*4+0x101cf7ac] */
            ii(0x1016_a14a, 6);  mov(memd[ds, 0x101b_dde8], edx);      /* mov [0x101bdde8], edx */
            ii(0x1016_a150, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1016_a152, 2);  rep(() => movsd());                   /* rep movsd */
            ii(0x1016_a154, 2);  jmp(0x1016_a15b, 5); goto l_0x1016_a15b;/* jmp 0x1016a15b */
        l_0x1016_a156:
            ii(0x1016_a156, 5);  mov(eax, 0xffff_ffff);                /* mov eax, 0xffffffff */
        l_0x1016_a15b:
            ii(0x1016_a15b, 3);  add(esp, 4);                          /* add esp, 0x4 */
            ii(0x1016_a15e, 1);  pop(edi);                             /* pop edi */
            ii(0x1016_a15f, 1);  pop(esi);                             /* pop esi */
            ii(0x1016_a160, 1);  pop(edx);                             /* pop edx */
            ii(0x1016_a161, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1016_a162, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1016_a163, 1);  ret();                                /* ret */
        }
    }
}
