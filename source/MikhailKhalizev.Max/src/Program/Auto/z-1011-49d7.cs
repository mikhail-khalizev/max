using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e297ecf2-4b5c-4a8e-aacd-6cda448d4898")]
        public void Method_1011_49d7()
        {
            ii(0x1011_49d7, 5); pushd(0xdc);                            /* push 0xdc */
            ii(0x1011_49dc, 5); calld(Definitions.sys_check_available_stack_size, 0x5_1371); /* call 0x10165d52 */
            ii(0x1011_49e1, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_49e2, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_49e3, 1); pushd(edx);                             /* push edx */
            ii(0x1011_49e4, 1); pushd(esi);                             /* push esi */
            ii(0x1011_49e5, 1); pushd(edi);                             /* push edi */
            ii(0x1011_49e6, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_49e7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_49e9, 6); sub(esp, 0xc0);                         /* sub esp, 0xc0 */
            ii(0x1011_49ef, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_49f2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_49f5, 5); calld(0x1011_3b89, -0xe71);             /* call 0x10113b89 */
            ii(0x1011_49fa, 5); calld(0x1011_5358, 0x959);              /* call 0x10115358 */
            ii(0x1011_49ff, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_4a01, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1011_4a03, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_4a05, 5); mov(eax, 0x9);                          /* mov eax, 0x9 */
            ii(0x1011_4a0a, 5); calld(0x1011_1386, -0x3689);            /* call 0x10111386 */
            ii(0x1011_4a0f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_4a11, 6); if(jzd(0x1011_4b13, 0xfc)) goto l_0x1011_4b13; /* jz 0x10114b13 */
            ii(0x1011_4a17, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_4a19, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_4a1c, 3); mov(al, memb_a32[ds, edx + 0x11]);      /* mov al, [edx+0x11] */
            ii(0x1011_4a1f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_4a22, 5); mov(eax, 0x3d);                         /* mov eax, 0x3d */
            ii(0x1011_4a27, 5); calld(0x1007_5fdc, -0x9_ea50);          /* call 0x10075fdc */
            ii(0x1011_4a2c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_4a2f, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1011_4a32, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_4a35, 6); mov(memb_a32[ds, edx + 0x598], al);     /* mov [edx+0x598], al */
            ii(0x1011_4a3b, 5); calld(0x1011_5398, 0x958);              /* call 0x10115398 */
            ii(0x1011_4a40, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1011_4a42, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1011_4a44, 6); lea(ebx, ebp - 0xbc);                   /* lea ebx, [ebp-0xbc] */
            ii(0x1011_4a4a, 5); mov(edx, 0x9);                          /* mov edx, 0x9 */
            ii(0x1011_4a4f, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1011_4a53, 5); calld(0x1013_9ade, 0x2_5086);           /* call 0x10139ade */
            ii(0x1011_4a58, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_4a5b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_4a5d, 6); mov(dl, memb_a32[ds, eax + 0x50f]);     /* mov dl, [eax+0x50f] */
            ii(0x1011_4a63, 5); mov(eax, 0x49);                         /* mov eax, 0x49 */
            ii(0x1011_4a68, 5); calld(0x100c_aafc, -0x4_9f71);          /* call 0x100caafc */
            ii(0x1011_4a6d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_4a70, 6); mov(edx, memd_a32[ds, eax + 0x50e]);    /* mov edx, [eax+0x50e] */
            ii(0x1011_4a76, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_4a79, 5); mov(eax, 0x46);                         /* mov eax, 0x46 */
            ii(0x1011_4a7e, 5); calld(0x100c_aafc, -0x4_9f87);          /* call 0x100caafc */
            ii(0x1011_4a83, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_4a86, 6); mov(edx, memd_a32[ds, eax + 0x510]);    /* mov edx, [eax+0x510] */
            ii(0x1011_4a8c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_4a8f, 5); mov(eax, 0x47);                         /* mov eax, 0x47 */
            ii(0x1011_4a94, 5); calld(0x100c_aafc, -0x4_9f9d);          /* call 0x100caafc */
            ii(0x1011_4a99, 10); mov(memd_a32[ss, ebp - 0xc0], 0x4);    /* mov dword [ebp-0xc0], 0x4 */
        l_0x1011_4aa3:
            ii(0x1011_4aa3, 6); dec(memd_a32[ss, ebp - 0xc0]);          /* dec dword [ebp-0xc0] */
            ii(0x1011_4aa9, 8); cmp(memw_a32[ss, ebp - 0xc0], -0x1 /* 0xff */); /* cmp word [ebp-0xc0], 0xffff */
            ii(0x1011_4ab1, 2); if(jzd(0x1011_4ad5, 0x22)) goto l_0x1011_4ad5; /* jz 0x10114ad5 */
            ii(0x1011_4ab3, 7); movsx(eax, memw_a32[ss, ebp - 0xc0]);   /* movsx eax, word [ebp-0xc0] */
            ii(0x1011_4aba, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_4abc, 4); mov(dl, memb_a32[ds, eax + ebp - 0x1b]); /* mov dl, [eax+ebp-0x1b] */
            ii(0x1011_4ac0, 7); movsx(eax, memw_a32[ss, ebp - 0xc0]);   /* movsx eax, word [ebp-0xc0] */
            ii(0x1011_4ac7, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_4ac9, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1011_4acc, 7); mov(memw_a32[ds, eax + 0x4e4], dx);     /* mov [eax+0x4e4], dx */
            ii(0x1011_4ad3, 2); jmpd(0x1011_4aa3, -0x32); goto l_0x1011_4aa3; /* jmp 0x10114aa3 */
        l_0x1011_4ad5:
            ii(0x1011_4ad5, 5); mov(edx, 0xa);                          /* mov edx, 0xa */
            ii(0x1011_4ada, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_4add, 5); calld(0x1011_2a06, -0x20dc);            /* call 0x10112a06 */
            ii(0x1011_4ae2, 6); lea(edx, ebp - 0xbc);                   /* lea edx, [ebp-0xbc] */
            ii(0x1011_4ae8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_4aeb, 5); calld(0x1011_46da, -0x416);             /* call 0x101146da */
            ii(0x1011_4af0, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1011_4af5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_4af8, 5); calld(0x1011_3aca, -0x1033);            /* call 0x10113aca */
            ii(0x1011_4afd, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1011_4b01, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_4b04, 5); calld(0x1011_3d56, -0xdb3);             /* call 0x10113d56 */
            ii(0x1011_4b09, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_4b0c, 5); calld(0x1011_390d, -0x1204);            /* call 0x1011390d */
            ii(0x1011_4b11, 2); jmpd(0x1011_4b20, 0xd); goto l_0x1011_4b20; /* jmp 0x10114b20 */
        l_0x1011_4b13:
            ii(0x1011_4b13, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1011_4b18, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_4b1b, 5); calld(0x1011_3aca, -0x1056);            /* call 0x10113aca */
        l_0x1011_4b20:
            ii(0x1011_4b20, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_4b22, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_4b23, 1); popd(edi);                              /* pop edi */
            ii(0x1011_4b24, 1); popd(esi);                              /* pop esi */
            ii(0x1011_4b25, 1); popd(edx);                              /* pop edx */
            ii(0x1011_4b26, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_4b27, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_4b28, 1); retd(); return;                         /* ret */
        }
    }
}
