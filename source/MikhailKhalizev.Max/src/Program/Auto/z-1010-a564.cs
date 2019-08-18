using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_a564-82e82158")]
        public void Method_1010_a564()
        {
            ii(0x1010_a564, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1010_a569, 5); calld(Definitions.sys_check_available_stack_size, 0x5_b7e4); /* call 0x10165d52 */
            ii(0x1010_a56e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_a56f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_a570, 1); pushd(edx);                             /* push edx */
            ii(0x1010_a571, 1); pushd(esi);                             /* push esi */
            ii(0x1010_a572, 1); pushd(edi);                             /* push edi */
            ii(0x1010_a573, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_a574, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_a576, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1010_a57c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_a57f, 5); mov(edx, 0x5);                          /* mov edx, 0x5 */
            ii(0x1010_a584, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_a587, 5); calld(0x1010_a26b, -0x321);             /* call 0x1010a26b */
            ii(0x1010_a58c, 5); calld(0x1011_52a8, 0xad17);             /* call 0x101152a8 */
            ii(0x1010_a591, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_a593, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1010_a595, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1010_a598, 5); calld(0x1011_52c8, 0xad2b);             /* call 0x101152c8 */
            ii(0x1010_a59d, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1010_a59f, 5); mov(edx, 0x101b_a908);                  /* mov edx, 0x101ba908 */
            ii(0x1010_a5a4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_a5a7, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_a5a9, 5); calld(0x1010_a2d7, -0x2d7);             /* call 0x1010a2d7 */
            ii(0x1010_a5ae, 5); calld(0x1011_52a8, 0xacf5);             /* call 0x101152a8 */
            ii(0x1010_a5b3, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_a5b5, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1010_a5b7, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1010_a5ba, 5); calld(0x1011_52c8, 0xad09);             /* call 0x101152c8 */
            ii(0x1010_a5bf, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1010_a5c1, 5); mov(edx, 0x101b_a91c);                  /* mov edx, 0x101ba91c */
            ii(0x1010_a5c6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_a5c9, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_a5cb, 5); calld(0x1010_a2d7, -0x2f9);             /* call 0x1010a2d7 */
            ii(0x1010_a5d0, 5); calld(0x1011_52a8, 0xacd3);             /* call 0x101152a8 */
            ii(0x1010_a5d5, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_a5d7, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1010_a5d9, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1010_a5dc, 5); calld(0x1011_52c8, 0xace7);             /* call 0x101152c8 */
            ii(0x1010_a5e1, 5); mov(edx, 0x101b_a930);                  /* mov edx, 0x101ba930 */
            ii(0x1010_a5e6, 3); mov(esi, memd_a32[ss, ebp - 0x4]);      /* mov esi, [ebp-0x4] */
            ii(0x1010_a5e9, 2); mov(esi, memd_a32[ds, esi]);            /* mov esi, [esi] */
            ii(0x1010_a5eb, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1010_a5ed, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1010_a5ef, 5); calld(0x1010_a2d7, -0x31d);             /* call 0x1010a2d7 */
            ii(0x1010_a5f4, 5); calld(0x1011_52a8, 0xacaf);             /* call 0x101152a8 */
            ii(0x1010_a5f9, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_a5fb, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1010_a5fd, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1010_a600, 5); calld(0x1011_52c8, 0xacc3);             /* call 0x101152c8 */
            ii(0x1010_a605, 5); mov(edx, 0x101b_a944);                  /* mov edx, 0x101ba944 */
            ii(0x1010_a60a, 3); mov(esi, memd_a32[ss, ebp - 0x4]);      /* mov esi, [ebp-0x4] */
            ii(0x1010_a60d, 2); mov(esi, memd_a32[ds, esi]);            /* mov esi, [esi] */
            ii(0x1010_a60f, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1010_a611, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1010_a613, 5); calld(0x1010_a2d7, -0x341);             /* call 0x1010a2d7 */
            ii(0x1010_a618, 5); mov(eax, 0x4d);                         /* mov eax, 0x4d */
            ii(0x1010_a61d, 5); calld(0x1007_5fdc, -0x9_4646);          /* call 0x10075fdc */
            ii(0x1010_a622, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1010_a625, 5); mov(ebx, 0x2f);                         /* mov ebx, 0x2f */
            ii(0x1010_a62a, 5); mov(edx, 0x3);                          /* mov edx, 0x3 */
            ii(0x1010_a62f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_a632, 5); calld(0x1010_a36e, -0x2c9);             /* call 0x1010a36e */
            ii(0x1010_a637, 5); mov(eax, 0x4e);                         /* mov eax, 0x4e */
            ii(0x1010_a63c, 5); calld(0x1007_5fdc, -0x9_4665);          /* call 0x10075fdc */
            ii(0x1010_a641, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1010_a644, 5); mov(ebx, 0x32);                         /* mov ebx, 0x32 */
            ii(0x1010_a649, 5); mov(edx, 0x3);                          /* mov edx, 0x3 */
            ii(0x1010_a64e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_a651, 5); calld(0x1010_a36e, -0x2e8);             /* call 0x1010a36e */
            ii(0x1010_a656, 5); mov(eax, 0x4f);                         /* mov eax, 0x4f */
            ii(0x1010_a65b, 5); calld(0x1007_5fdc, -0x9_4684);          /* call 0x10075fdc */
            ii(0x1010_a660, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1010_a663, 5); mov(ebx, 0x35);                         /* mov ebx, 0x35 */
            ii(0x1010_a668, 5); mov(edx, 0x3);                          /* mov edx, 0x3 */
            ii(0x1010_a66d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_a670, 5); calld(0x1010_a36e, -0x307);             /* call 0x1010a36e */
            ii(0x1010_a675, 5); mov(eax, 0x50);                         /* mov eax, 0x50 */
            ii(0x1010_a67a, 5); calld(0x1007_5fdc, -0x9_46a3);          /* call 0x10075fdc */
            ii(0x1010_a67f, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1010_a682, 5); mov(ebx, 0x38);                         /* mov ebx, 0x38 */
            ii(0x1010_a687, 5); mov(edx, 0x3);                          /* mov edx, 0x3 */
            ii(0x1010_a68c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_a68f, 5); calld(0x1010_a36e, -0x326);             /* call 0x1010a36e */
            ii(0x1010_a694, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_a696, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_a697, 1); popd(edi);                              /* pop edi */
            ii(0x1010_a698, 1); popd(esi);                              /* pop esi */
            ii(0x1010_a699, 1); popd(edx);                              /* pop edx */
            ii(0x1010_a69a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_a69b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_a69c, 1); retd(); return;                         /* ret */
        }
    }
}
