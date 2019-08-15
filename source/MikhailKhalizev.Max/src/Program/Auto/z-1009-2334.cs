using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("83978f76-e268-43b9-ba3c-6eeb63b6ceba")]
        public void Method_1009_2334()
        {
            ii(0x1009_2334, 5); pushd(0x58);                            /* push 0x58 */
            ii(0x1009_2339, 5); calld(Definitions.sys_check_available_stack_size, 0xd_3a14); /* call 0x10165d52 */
            ii(0x1009_233e, 1); pushd(esi);                             /* push esi */
            ii(0x1009_233f, 1); pushd(edi);                             /* push edi */
            ii(0x1009_2340, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_2341, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_2343, 6); sub(esp, 0x38);                         /* sub esp, 0x38 */
            ii(0x1009_2349, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_234c, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1009_234f, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1009_2352, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x1009_2355, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1009_2358, 5); calld(Definitions.my_ctor_0x101b4184, -0x1_b86d); /* call 0x10076af0 */
            ii(0x1009_235d, 5); cmp(memw_a32[ss, ebp - 0x4], 0x28);     /* cmp word [ebp-0x4], 0x28 */
            ii(0x1009_2362, 6); if(jnzd(0x1009_241a, 0xb2)) goto l_0x1009_241a; /* jnz 0x1009241a */
            ii(0x1009_2368, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_236b, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1009_236e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_2371, 1); pushd(eax);                             /* push eax */
            ii(0x1009_2372, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1009_2374, 1); pushd(eax);                             /* push eax */
            ii(0x1009_2375, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_2378, 1); pushd(eax);                             /* push eax */
            ii(0x1009_2379, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1009_237c, 1); pushd(eax);                             /* push eax */
            ii(0x1009_237d, 3); lea(ecx, ebp - 0x24);                   /* lea ecx, [ebp-0x24] */
            ii(0x1009_2380, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1009_2385, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_2388, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1009_238a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_238d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_2390, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1009_2393, 5); calld(0x1014_2d0b, 0xb_0973);           /* call 0x10142d0b */
            ii(0x1009_2398, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1009_239b, 3); add(eax, memd_a32[ss, ebp - 0x1c]);     /* add eax, [ebp-0x1c] */
            ii(0x1009_239e, 3); mov(edx, memd_a32[ss, ebp - 0x24]);     /* mov edx, [ebp-0x24] */
            ii(0x1009_23a1, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_23a3, 3); mov(memd_a32[ss, ebp - 0x14], edx);     /* mov [ebp-0x14], edx */
            ii(0x1009_23a6, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_23a9, 3); mov(eax, memd_a32[ds, eax + 0x2b]);     /* mov eax, [eax+0x2b] */
            ii(0x1009_23ac, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_23af, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x1009_23b3, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_23b5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_23b7, 2); if(jged(0x1009_23cb, 0x12)) goto l_0x1009_23cb; /* jge 0x100923cb */
            ii(0x1009_23b9, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_23bc, 3); mov(edx, memd_a32[ss, ebp - 0x24]);     /* mov edx, [ebp-0x24] */
            ii(0x1009_23bf, 4); add(dx, memw_a32[ds, eax + 0x2d]);      /* add dx, [eax+0x2d] */
            ii(0x1009_23c3, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1009_23c5, 3); imul(eax, eax, 0x64);                   /* imul eax, eax, 0x64 */
            ii(0x1009_23c8, 3); add(memd_a32[ss, ebp - 0x14], eax);     /* add [ebp-0x14], eax */
        l_0x1009_23cb:
            ii(0x1009_23cb, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_23ce, 3); mov(eax, memd_a32[ds, eax + 0x2d]);     /* mov eax, [eax+0x2d] */
            ii(0x1009_23d1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_23d4, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1009_23d8, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_23da, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_23dc, 2); if(jged(0x1009_23f0, 0x12)) goto l_0x1009_23f0; /* jge 0x100923f0 */
            ii(0x1009_23de, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_23e1, 3); mov(edx, memd_a32[ss, ebp - 0x1c]);     /* mov edx, [ebp-0x1c] */
            ii(0x1009_23e4, 4); add(dx, memw_a32[ds, eax + 0x2f]);      /* add dx, [eax+0x2f] */
            ii(0x1009_23e8, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1009_23ea, 3); imul(eax, eax, 0x64);                   /* imul eax, eax, 0x64 */
            ii(0x1009_23ed, 3); add(memd_a32[ss, ebp - 0x14], eax);     /* add [ebp-0x14], eax */
        l_0x1009_23f0:
            ii(0x1009_23f0, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_23f3, 3); mov(eax, memd_a32[ds, eax + 0x29]);     /* mov eax, [eax+0x29] */
            ii(0x1009_23f6, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_23f9, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x1009_23fd, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_23ff, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_2401, 2); if(jged(0x1009_2415, 0x12)) goto l_0x1009_2415; /* jge 0x10092415 */
            ii(0x1009_2403, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_2406, 3); mov(edx, memd_a32[ss, ebp - 0x20]);     /* mov edx, [ebp-0x20] */
            ii(0x1009_2409, 4); add(dx, memw_a32[ds, eax + 0x2b]);      /* add dx, [eax+0x2b] */
            ii(0x1009_240d, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1009_240f, 3); imul(eax, eax, 0x64);                   /* imul eax, eax, 0x64 */
            ii(0x1009_2412, 3); add(memd_a32[ss, ebp - 0x14], eax);     /* add [ebp-0x14], eax */
        l_0x1009_2415:
            ii(0x1009_2415, 5); jmpd(0x1009_24a7, 0x8d); goto l_0x1009_24a7; /* jmp 0x100924a7 */
        l_0x1009_241a:
            ii(0x1009_241a, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1009_241d, 3); add(edx, 0x13);                         /* add edx, 0x13 */
            ii(0x1009_2420, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x1009_2423, 5); calld(0x1007_5e64, -0x1_c5c4);          /* call 0x10075e64 */
            ii(0x1009_2428, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1009_242a, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_242d, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1009_2430, 5); calld(0x1007_5e64, -0x1_c5d1);          /* call 0x10075e64 */
            ii(0x1009_2435, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1009_2437, 5); calld(0x100a_5fca, 0x1_3b8e);           /* call 0x100a5fca */
            ii(0x1009_243c, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1009_243f, 3); neg(memd_a32[ss, ebp - 0x14]);          /* neg dword [ebp-0x14] */
            ii(0x1009_2442, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_2445, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x1009_2448, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1009_244b, 3); add(edx, memd_a32[ss, ebp - 0xc]);      /* add edx, [ebp-0xc] */
            ii(0x1009_244e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_2451, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1009_2453, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_2456, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1009_2458, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1009_245a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_245c, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1009_245f, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1009_2462, 2); jmpd(0x1009_2481, 0x1d); goto l_0x1009_2481; /* jmp 0x10092481 */
        l_0x1009_2464:
            ii(0x1009_2464, 7); add(memd_a32[ss, ebp - 0x14], 0xffff_fc18); /* add dword [ebp-0x14], 0xfffffc18 */
            ii(0x1009_246b, 2); jmpd(0x1009_24a7, 0x3a); goto l_0x1009_24a7; /* jmp 0x100924a7 */
        l_0x1009_246d:
            ii(0x1009_246d, 7); add(memd_a32[ss, ebp - 0x14], 0xffff_f830); /* add dword [ebp-0x14], 0xfffff830 */
            ii(0x1009_2474, 2); jmpd(0x1009_24a7, 0x31); goto l_0x1009_24a7; /* jmp 0x100924a7 */
        l_0x1009_2476:
            ii(0x1009_2476, 7); add(memd_a32[ss, ebp - 0x14], 0xffff_f448); /* add dword [ebp-0x14], 0xfffff448 */
            ii(0x1009_247d, 2); jmpd(0x1009_24a7, 0x28); goto l_0x1009_24a7; /* jmp 0x100924a7 */
        l_0x1009_247f:
            ii(0x1009_247f, 2); jmpd(0x1009_24a7, 0x26); goto l_0x1009_24a7; /* jmp 0x100924a7 */
        l_0x1009_2481:
            ii(0x1009_2481, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1009_2484, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1009_2487, 5); cmp(memw_a32[ss, ebp - 0x34], 0x2);     /* cmp word [ebp-0x34], 0x2 */
            ii(0x1009_248c, 2); if(jbd(0x1009_249e, 0x10)) goto l_0x1009_249e; /* jb 0x1009249e */
            ii(0x1009_248e, 5); cmp(memw_a32[ss, ebp - 0x34], 0x2);     /* cmp word [ebp-0x34], 0x2 */
            ii(0x1009_2493, 2); if(jbed(0x1009_246d, -0x28)) goto l_0x1009_246d; /* jbe 0x1009246d */
            ii(0x1009_2495, 5); cmp(memw_a32[ss, ebp - 0x34], 0x3);     /* cmp word [ebp-0x34], 0x3 */
            ii(0x1009_249a, 2); if(jzd(0x1009_2476, -0x26)) goto l_0x1009_2476; /* jz 0x10092476 */
            ii(0x1009_249c, 2); jmpd(0x1009_247f, -0x1f); goto l_0x1009_247f; /* jmp 0x1009247f */
        l_0x1009_249e:
            ii(0x1009_249e, 5); cmp(memw_a32[ss, ebp - 0x34], 0x1);     /* cmp word [ebp-0x34], 0x1 */
            ii(0x1009_24a3, 2); if(jzd(0x1009_2464, -0x41)) goto l_0x1009_2464; /* jz 0x10092464 */
            ii(0x1009_24a5, 2); jmpd(0x1009_247f, -0x28); goto l_0x1009_247f; /* jmp 0x1009247f */
        l_0x1009_24a7:
            ii(0x1009_24a7, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1009_24aa, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1009_24ad, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1009_24b0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_24b2, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_24b3, 1); popd(edi);                              /* pop edi */
            ii(0x1009_24b4, 1); popd(esi);                              /* pop esi */
            ii(0x1009_24b5, 1); retd(); return;                         /* ret */
        }
    }
}
