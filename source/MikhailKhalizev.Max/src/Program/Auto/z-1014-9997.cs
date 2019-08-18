using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e22b260e-8836-40cb-a74f-c8ff927bb5e3")]
        public void Method_1014_9997()
        {
            ii(0x1014_9997, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x1014_999c, 5); calld(Definitions.sys_check_available_stack_size, 0x1_c3b1); /* call 0x10165d52 */
            ii(0x1014_99a1, 1); pushd(esi);                             /* push esi */
            ii(0x1014_99a2, 1); pushd(edi);                             /* push edi */
            ii(0x1014_99a3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_99a4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_99a6, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x1014_99ac, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_99af, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1014_99b2, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1014_99b5, 3); mov(memd_a32[ss, ebp - 0xc], ecx);      /* mov [ebp-0xc], ecx */
            ii(0x1014_99b8, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1014_99bc, 6); if(jzd(0x1014_9aaf, 0xed)) goto l_0x1014_9aaf; /* jz 0x10149aaf */
            ii(0x1014_99c2, 4); movsx(edx, memw_a32[ss, ebp + 0x10]);   /* movsx edx, word [ebp+0x10] */
            ii(0x1014_99c6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_99c9, 5); calld(0x1014_98f1, -0xdd);              /* call 0x101498f1 */
            ii(0x1014_99ce, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1014_99d1, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1014_99d4, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1014_99d7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_99d9, 2); if(jled(0x1014_99e7, 0xc)) goto l_0x1014_99e7; /* jle 0x101499e7 */
            ii(0x1014_99db, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1014_99de, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1014_99e0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_99e3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_99e5, 2); if(jgd(0x1014_99ec, 0x5)) goto l_0x1014_99ec; /* jg 0x101499ec */
        l_0x1014_99e7:
            ii(0x1014_99e7, 5); jmpd(0x1014_9aaf, 0xc3); goto l_0x1014_9aaf; /* jmp 0x10149aaf */
        l_0x1014_99ec:
            ii(0x1014_99ec, 7); cmp(memb_a32[ds, 0x101c_814a], 0);      /* cmp byte [0x101c814a], 0x0 */
            ii(0x1014_99f3, 2); if(jzd(0x1014_99fe, 0x9)) goto l_0x1014_99fe; /* jz 0x101499fe */
            ii(0x1014_99f5, 7); mov(memd_a32[ss, ebp - 0x14], 0x2);     /* mov dword [ebp-0x14], 0x2 */
            ii(0x1014_99fc, 2); jmpd(0x1014_9a05, 0x7); goto l_0x1014_9a05; /* jmp 0x10149a05 */
        l_0x1014_99fe:
            ii(0x1014_99fe, 7); mov(memd_a32[ss, ebp - 0x14], 0x1);     /* mov dword [ebp-0x14], 0x1 */
        l_0x1014_9a05:
            ii(0x1014_9a05, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1014_9a08, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1014_9a0b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_9a0e, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1014_9a12, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1014_9a15, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1014_9a19, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1014_9a1b, 3); mov(memd_a32[ss, ebp - 0x28], edx);     /* mov [ebp-0x28], edx */
            ii(0x1014_9a1e, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1014_9a21, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x1014_9a24, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_9a27, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1014_9a2b, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1014_9a2e, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1014_9a32, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1014_9a34, 3); mov(memd_a32[ss, ebp - 0x24], edx);     /* mov [ebp-0x24], edx */
            ii(0x1014_9a37, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1014_9a3a, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x1014_9a3d, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1014_9a41, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1014_9a44, 3); add(eax, memd_a32[ss, ebp - 0x28]);     /* add eax, [ebp-0x28] */
            ii(0x1014_9a47, 1); dec(eax);                               /* dec eax */
            ii(0x1014_9a48, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1014_9a4b, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1014_9a4e, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1014_9a50, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_9a53, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1014_9a57, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1014_9a5a, 3); add(eax, memd_a32[ss, ebp - 0x24]);     /* add eax, [ebp-0x24] */
            ii(0x1014_9a5d, 1); dec(eax);                               /* dec eax */
            ii(0x1014_9a5e, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1014_9a61, 3); mov(edx, memd_a32[ss, ebp - 0x28]);     /* mov edx, [ebp-0x28] */
            ii(0x1014_9a64, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9a67, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1014_9a69, 5); calld(Definitions.my_min, -0xc_02ea);   /* call 0x10089784 */
            ii(0x1014_9a6e, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1014_9a71, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x1014_9a73, 3); mov(edx, memd_a32[ss, ebp - 0x24]);     /* mov edx, [ebp-0x24] */
            ii(0x1014_9a76, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9a79, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x1014_9a7c, 5); calld(Definitions.my_min, -0xc_02fd);   /* call 0x10089784 */
            ii(0x1014_9a81, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1014_9a84, 3); mov(memd_a32[ds, edx + 0x4], eax);      /* mov [edx+0x4], eax */
            ii(0x1014_9a87, 3); mov(edx, memd_a32[ss, ebp - 0x20]);     /* mov edx, [ebp-0x20] */
            ii(0x1014_9a8a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9a8d, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x1014_9a90, 5); calld(0x1007_6e7c, -0xd_2c19);          /* call 0x10076e7c */
            ii(0x1014_9a95, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1014_9a98, 3); mov(memd_a32[ds, edx + 0x8], eax);      /* mov [edx+0x8], eax */
            ii(0x1014_9a9b, 3); mov(edx, memd_a32[ss, ebp - 0x1c]);     /* mov edx, [ebp-0x1c] */
            ii(0x1014_9a9e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_9aa1, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x1014_9aa4, 5); calld(0x1007_6e7c, -0xd_2c2d);          /* call 0x10076e7c */
            ii(0x1014_9aa9, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1014_9aac, 3); mov(memd_a32[ds, edx + 0xc], eax);      /* mov [edx+0xc], eax */
        l_0x1014_9aaf:
            ii(0x1014_9aaf, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_9ab1, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_9ab2, 1); popd(edi);                              /* pop edi */
            ii(0x1014_9ab3, 1); popd(esi);                              /* pop esi */
            ii(0x1014_9ab4, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}
