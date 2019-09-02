using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_4539-7a1a855b")]
        public void Method_100e_4539()
        {
            ii(0x100e_4539, 5); push(0x4c);                             /* push 0x4c */
            ii(0x100e_453e, 5); call(Definitions.sys_check_available_stack_size, 0x8_180f); /* call 0x10165d52 */
            ii(0x100e_4543, 1); push(ebx);                              /* push ebx */
            ii(0x100e_4544, 1); push(ecx);                              /* push ecx */
            ii(0x100e_4545, 1); push(edx);                              /* push edx */
            ii(0x100e_4546, 1); push(esi);                              /* push esi */
            ii(0x100e_4547, 1); push(edi);                              /* push edi */
            ii(0x100e_4548, 1); push(ebp);                              /* push ebp */
            ii(0x100e_4549, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_454b, 6); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x100e_4551, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_4554, 7); cmp(memd[ds, 0x101b_7f04], 0);          /* cmp dword [0x101b7f04], 0x0 */
            ii(0x100e_455b, 2); if(jnz(0x100e_45ad, 0x50)) goto l_0x100e_45ad; /* jnz 0x100e45ad */
            ii(0x100e_455d, 10); mov(memd[ds, 0x101b_7f04], 1);         /* mov dword [0x101b7f04], 0x1 */
            ii(0x100e_4567, 5); mov(edx, 0x101c_360c);                  /* mov edx, 0x101c360c */
            ii(0x100e_456c, 5); mov(eax, 0x1000);                       /* mov eax, 0x1000 */
            ii(0x100e_4571, 5); call(0x100e_43e1, -0x195);              /* call 0x100e43e1 */
            ii(0x100e_4576, 5); mov(memd[ds, 0x101b_7f08], eax);        /* mov [0x101b7f08], eax */
            ii(0x100e_457b, 7); cmp(memd[ds, 0x101b_7f08], 0);          /* cmp dword [0x101b7f08], 0x0 */
            ii(0x100e_4582, 2); if(jnz(0x100e_459e, 0x1a)) goto l_0x100e_459e; /* jnz 0x100e459e */
            ii(0x100e_4584, 5); mov(eax, StringDefinitions.ErrorAllocatingRealModeStack); /* mov eax, 0x101a1c5c */
            ii(0x100e_4589, 1); push(eax);                              /* push eax */
            ii(0x100e_458a, 5); call(Definitions.sys_printf, 0x8_80ad); /* call 0x1016c63c */
            ii(0x100e_458f, 3); add(esp, 4);                            /* add esp, 0x4 */
            ii(0x100e_4592, 10); mov(memd[ds, 0x101b_7f0c], 0);         /* mov dword [0x101b7f0c], 0x0 */
            ii(0x100e_459c, 2); jmp(0x100e_45ad, 0xf); goto l_0x100e_45ad; /* jmp 0x100e45ad */
        l_0x100e_459e:
            ii(0x100e_459e, 5); mov(eax, memd[ds, 0x101b_7f08]);        /* mov eax, [0x101b7f08] */
            ii(0x100e_45a3, 5); add(eax, 0x1000);                       /* add eax, 0x1000 */
            ii(0x100e_45a8, 5); mov(memd[ds, 0x101b_7f0c], eax);        /* mov [0x101b7f0c], eax */
        l_0x100e_45ad:
            ii(0x100e_45ad, 7); cmp(memd[ds, 0x101b_7f0c], 0);          /* cmp dword [0x101b7f0c], 0x0 */
            ii(0x100e_45b4, 2); if(jz(0x100e_45de, 0x28)) goto l_0x100e_45de; /* jz 0x100e45de */
            ii(0x100e_45b6, 5); mov(eax, memd[ds, 0x101b_7f0c]);        /* mov eax, [0x101b7f0c] */
            ii(0x100e_45bb, 3); shr(eax, 4);                            /* shr eax, 0x4 */
            ii(0x100e_45be, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x100e_45c3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_45c5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_45c8, 4); mov(memw[ds, eax + 48], dx);            /* mov [eax+0x30], dx */
            ii(0x100e_45cc, 6); mov(ax, memw[ds, 0x101b_7f0c]);         /* mov ax, [0x101b7f0c] */
            ii(0x100e_45d2, 5); and(eax, 0xf);                          /* and eax, 0xf */
            ii(0x100e_45d7, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100e_45da, 4); mov(memw[ds, edx + 46], ax);            /* mov [edx+0x2e], ax */
        l_0x100e_45de:
            ii(0x100e_45de, 5); mov(ebx, 0x1c);                         /* mov ebx, 0x1c */
            ii(0x100e_45e3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_45e5, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x100e_45e8, 5); call(Definitions.sys_memset, 0x8_17f3); /* call 0x10165de0 */
            ii(0x100e_45ed, 5); mov(ebx, 0xc);                          /* mov ebx, 0xc */
            ii(0x100e_45f2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_45f4, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x100e_45f7, 5); call(Definitions.sys_memset, 0x8_17e4); /* call 0x10165de0 */
            ii(0x100e_45fc, 6); mov(memw[ss, ebp - 44], 0x301);         /* mov word [ebp-0x2c], 0x301 */
            ii(0x100e_4602, 4); mov(memb[ss, ebp - 39], 0);             /* mov byte [ebp-0x27], 0x0 */
            ii(0x100e_4606, 6); mov(memw[ss, ebp - 36], 0);             /* mov word [ebp-0x24], 0x0 */
            ii(0x100e_460c, 2); mov(eax, ds);                           /* mov eax, ds */
            ii(0x100e_460e, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x100e_4611, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_4613, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100e_4615, 4); mov(memw[ss, ebp - 16], dx);            /* mov [ebp-0x10], dx */
            ii(0x100e_4619, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_461c, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x100e_461f, 3); lea(ecx, memd[ss, ebp - 16]);           /* lea ecx, [ebp-0x10] */
            ii(0x100e_4622, 3); lea(ebx, memd[ss, ebp - 44]);           /* lea ebx, [ebp-0x2c] */
            ii(0x100e_4625, 3); lea(edx, memd[ss, ebp - 44]);           /* lea edx, [ebp-0x2c] */
            ii(0x100e_4628, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x100e_462d, 5); call(/* sys */ 0x1016_c623, 0x8_7ff1);  /* call 0x1016c623 */
            ii(0x100e_4632, 4); cmp(memd[ss, ebp - 20], 0);             /* cmp dword [ebp-0x14], 0x0 */
            ii(0x100e_4636, 2); if(jz(0x100e_4643, 0xb)) goto l_0x100e_4643; /* jz 0x100e4643 */
            ii(0x100e_4638, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_463a, 4); mov(ax, memw[ss, ebp - 44]);            /* mov ax, [ebp-0x2c] */
            ii(0x100e_463e, 5); call(Definitions.sys_exit, 0x8_801c);   /* call 0x1016c65f */
        l_0x100e_4643:
            ii(0x100e_4643, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_4645, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_4646, 1); pop(edi);                               /* pop edi */
            ii(0x100e_4647, 1); pop(esi);                               /* pop esi */
            ii(0x100e_4648, 1); pop(edx);                               /* pop edx */
            ii(0x100e_4649, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_464a, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_464b, 1); ret();                                  /* ret */
        }
    }
}
