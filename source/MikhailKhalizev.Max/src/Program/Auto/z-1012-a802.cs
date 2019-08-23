using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_a802-8cae87cb")]
        public void Method_1012_a802()
        {
            ii(0x1012_a802, 5); push(0x4c);                             /* push 0x4c */
            ii(0x1012_a807, 5); call(Definitions.sys_check_available_stack_size, 0x3_b546); /* call 0x10165d52 */
            ii(0x1012_a80c, 1); push(ebx);                              /* push ebx */
            ii(0x1012_a80d, 1); push(ecx);                              /* push ecx */
            ii(0x1012_a80e, 1); push(edx);                              /* push edx */
            ii(0x1012_a80f, 1); push(esi);                              /* push esi */
            ii(0x1012_a810, 1); push(edi);                              /* push edi */
            ii(0x1012_a811, 1); push(ebp);                              /* push ebp */
            ii(0x1012_a812, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_a814, 6); sub(esp, 0x30);                         /* sub esp, 0x30 */
            ii(0x1012_a81a, 7); mov(memb[ds, 0x101c_3970], 0);          /* mov byte [0x101c3970], 0x0 */
            ii(0x1012_a821, 7); cmp(memd[ds, 0x101c_562c], 0);          /* cmp dword [0x101c562c], 0x0 */
            ii(0x1012_a828, 2); if(jz(0x1012_a882, 0x58)) goto l_0x1012_a882; /* jz 0x1012a882 */
            ii(0x1012_a82a, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x1012_a82f, 5); call(0x1012_9f96, -0x89e);              /* call 0x10129f96 */
            ii(0x1012_a834, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_a836, 2); if(jz(0x1012_a86c, 0x34)) goto l_0x1012_a86c; /* jz 0x1012a86c */
            ii(0x1012_a838, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x1012_a83d, 5); call(0x1012_9f96, -0x8ac);              /* call 0x10129f96 */
            ii(0x1012_a842, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_a844, 2); if(jz(0x1012_a86c, 0x26)) goto l_0x1012_a86c; /* jz 0x1012a86c */
            ii(0x1012_a846, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1012_a84b, 5); call(0x1012_9f96, -0x8ba);              /* call 0x10129f96 */
            ii(0x1012_a850, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_a852, 2); if(jz(0x1012_a86c, 0x18)) goto l_0x1012_a86c; /* jz 0x1012a86c */
            ii(0x1012_a854, 5); mov(eax, 0x101c_8178);                  /* mov eax, 0x101c8178 */
            ii(0x1012_a859, 5); call(0x1012_9f96, -0x8c8);              /* call 0x10129f96 */
            ii(0x1012_a85e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_a860, 2); if(jz(0x1012_a86c, 0xa)) goto l_0x1012_a86c; /* jz 0x1012a86c */
            ii(0x1012_a862, 5); mov(eax, 0x101c_8190);                  /* mov eax, 0x101c8190 */
            ii(0x1012_a867, 5); call(0x1012_9f96, -0x8d6);              /* call 0x10129f96 */
        l_0x1012_a86c:
            ii(0x1012_a86c, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1012_a871, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_a873, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x1012_a878, 5); call(0x1012_8897, -0x1fe6);             /* call 0x10128897 */
            ii(0x1012_a87d, 5); jmp(0x1012_a93b, 0xb9); goto l_0x1012_a93b; /* jmp 0x1012a93b */
        l_0x1012_a882:
            ii(0x1012_a882, 7); mov(memb[ds, 0x101c_59ec], 0);          /* mov byte [0x101c59ec], 0x0 */
        l_0x1012_a889:
            ii(0x1012_a889, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_a88b, 5); mov(al, memb[ds, 0x101c_59ec]);         /* mov al, [0x101c59ec] */
            ii(0x1012_a890, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_a892, 6); if(jnz(0x1012_a93b, 0xa3)) goto l_0x1012_a93b; /* jnz 0x1012a93b */
            ii(0x1012_a898, 5); call(0x1012_75ed, -0x32b0);             /* call 0x101275ed */
            ii(0x1012_a89d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_a89f, 5); call(0x1010_0efe, -0x2_99a6);           /* call 0x10100efe */
            ii(0x1012_a8a4, 8); cmp(memw[ds, 0x101c_59ee], 0);          /* cmp word [0x101c59ee], 0x0 */
            ii(0x1012_a8ac, 6); if(jz(0x1012_a92d, 0x7b)) goto l_0x1012_a92d; /* jz 0x1012a92d */
            ii(0x1012_a8b2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_a8b4, 7); mov(dx, memw[ds, 0x101c_59ee]);         /* mov dx, [0x101c59ee] */
            ii(0x1012_a8bb, 5); mov(eax, 0x101c_39c0);                  /* mov eax, 0x101c39c0 */
            ii(0x1012_a8c0, 5); call(0x1010_3eba, -0x2_6a0b);           /* call 0x10103eba */
            ii(0x1012_a8c5, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x1012_a8c8, 4); cmp(memd[ss, ebp - 0x30], 0);           /* cmp dword [ebp-0x30], 0x0 */
            ii(0x1012_a8cc, 2); if(jnz(0x1012_a8dd, 0xf)) goto l_0x1012_a8dd; /* jnz 0x1012a8dd */
            ii(0x1012_a8ce, 5); mov(eax, memd[ds, 0x101c_59ec]);        /* mov eax, [0x101c59ec] */
            ii(0x1012_a8d3, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_a8d6, 5); call(0x1012_6a47, -0x3e94);             /* call 0x10126a47 */
            ii(0x1012_a8db, 2); jmp(0x1012_a90b, 0x2e); goto l_0x1012_a90b; /* jmp 0x1012a90b */
        l_0x1012_a8dd:
            ii(0x1012_a8dd, 3); lea(edx, memd[ss, ebp - 0x2c]);         /* lea edx, [ebp-0x2c] */
            ii(0x1012_a8e0, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1012_a8e3, 5); call(0x1012_62e2, -0x4606);             /* call 0x101262e2 */
            ii(0x1012_a8e8, 5); mov(ebx, 0x29);                         /* mov ebx, 0x29 */
            ii(0x1012_a8ed, 5); mov(edx, 0x101c_5e48);                  /* mov edx, 0x101c5e48 */
            ii(0x1012_a8f2, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x1012_a8f5, 5); call(/* sys */ 0x1016_61c4, 0x3_b8ca);  /* call 0x101661c4 */
            ii(0x1012_a8fa, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_a8fc, 2); if(jz(0x1012_a90b, 0xd)) goto l_0x1012_a90b; /* jz 0x1012a90b */
            ii(0x1012_a8fe, 5); mov(edx, 0x101c_5e48);                  /* mov edx, 0x101c5e48 */
            ii(0x1012_a903, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1012_a906, 5); call(0x1012_a310, -0x5fb);              /* call 0x1012a310 */
        l_0x1012_a90b:
            ii(0x1012_a90b, 9); mov(memw[ds, 0x101c_59ee], 0);          /* mov word [0x101c59ee], 0x0 */
            ii(0x1012_a914, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1012_a919, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_a91b, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x1012_a920, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_a923, 5); mov(eax, 0x18);                         /* mov eax, 0x18 */
            ii(0x1012_a928, 5); call(0x1012_8897, -0x2096);             /* call 0x10128897 */
        l_0x1012_a92d:
            ii(0x1012_a92d, 5); call(/* sys */ 0x1016_b208, 0x4_08d6);  /* call 0x1016b208 */
            ii(0x1012_a932, 3); cmp(eax, 0x1b);                         /* cmp eax, 0x1b */
            ii(0x1012_a935, 6); if(jnz(0x1012_a889, -0xb2)) goto l_0x1012_a889; /* jnz 0x1012a889 */
        l_0x1012_a93b:
            ii(0x1012_a93b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1012_a93d, 5); mov(edx, StringDefinitions.DebugSave);  /* mov edx, 0x101a8636 */
            ii(0x1012_a942, 5); mov(eax, StringDefinitions.SaveDbg);    /* mov eax, 0x101a8641 */
            ii(0x1012_a947, 5); call(0x1013_6e81, 0xc535);              /* call 0x10136e81 */
            ii(0x1012_a94c, 5); mov(eax, 0x46);                         /* mov eax, 0x46 */
            ii(0x1012_a951, 5); call(0x1007_5fdc, -0xb_497a);           /* call 0x10075fdc */
            ii(0x1012_a956, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_a958, 2); if(jz(0x1012_a961, 0x7)) goto l_0x1012_a961; /* jz 0x1012a961 */
            ii(0x1012_a95a, 7); mov(memb[ds, 0x101c_3970], 0x1);        /* mov byte [0x101c3970], 0x1 */
        l_0x1012_a961:
            ii(0x1012_a961, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_a963, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_a964, 1); pop(edi);                               /* pop edi */
            ii(0x1012_a965, 1); pop(esi);                               /* pop esi */
            ii(0x1012_a966, 1); pop(edx);                               /* pop edx */
            ii(0x1012_a967, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_a968, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_a969, 1); ret();                                  /* ret */
        }
    }
}
