using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c93e5bce-deb9-4614-97ba-dd8d389e9fa6")]
        public void Method_1013_fa8c()
        {
            ii(0x1013_fa8c, 5); pushd(0x40);                            /* push 0x40 */
            ii(0x1013_fa91, 5); calld(Definitions.sys_check_available_stack_size, 0x262bc); /* call 0x10165d52 */
            ii(0x1013_fa96, 1); pushd(esi);                             /* push esi */
            ii(0x1013_fa97, 1); pushd(edi);                             /* push edi */
            ii(0x1013_fa98, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_fa99, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_fa9b, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1013_faa1, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_faa4, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1013_faa7, 3); mov(memd_a32[ss, ebp - 0xc], ebx);      /* mov [ebp-0xc], ebx */
            ii(0x1013_faaa, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x1013_faad, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_fab0, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1013_fab3, 2); jmpd(0x1013_fae4, 0x2f); goto l_0x1013_fae4; /* jmp 0x1013fae4 */
        l_0x1013_fab5:
            ii(0x1013_fab5, 7); mov(memd_a32[ss, ebp - 0x18], 0x270);   /* mov dword [ebp-0x18], 0x270 */
            ii(0x1013_fabc, 5); jmpd(0x1013_fb52, 0x91); goto l_0x1013_fb52; /* jmp 0x1013fb52 */
        l_0x1013_fac1:
            ii(0x1013_fac1, 7); mov(memd_a32[ss, ebp - 0x18], 0x26f);   /* mov dword [ebp-0x18], 0x26f */
            ii(0x1013_fac8, 5); jmpd(0x1013_fb52, 0x85); goto l_0x1013_fb52; /* jmp 0x1013fb52 */
        l_0x1013_facd:
            ii(0x1013_facd, 7); mov(memd_a32[ss, ebp - 0x18], 0x272);   /* mov dword [ebp-0x18], 0x272 */
            ii(0x1013_fad4, 5); jmpd(0x1013_fb52, 0x79); goto l_0x1013_fb52; /* jmp 0x1013fb52 */
        l_0x1013_fad9:
            ii(0x1013_fad9, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_fadc, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1013_fadf, 5); jmpd(0x1013_fbf1, 0x10d); goto l_0x1013_fbf1; /* jmp 0x1013fbf1 */
        l_0x1013_fae4:
            ii(0x1013_fae4, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1013_fae7, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1013_faea, 5); cmp(memw_a32[ss, ebp - 0x20], 0x3b);    /* cmp word [ebp-0x20], 0x3b */
            ii(0x1013_faef, 2); if(jbd(0x1013_fb21, 0x30)) goto l_0x1013_fb21; /* jb 0x1013fb21 */
            ii(0x1013_faf1, 5); cmp(memw_a32[ss, ebp - 0x20], 0x3b);    /* cmp word [ebp-0x20], 0x3b */
            ii(0x1013_faf6, 2); if(jbed(0x1013_fab5, -0x43)) goto l_0x1013_fab5; /* jbe 0x1013fab5 */
            ii(0x1013_faf8, 5); cmp(memw_a32[ss, ebp - 0x20], 0x3d);    /* cmp word [ebp-0x20], 0x3d */
            ii(0x1013_fafd, 2); if(jbd(0x1013_fb1f, 0x20)) goto l_0x1013_fb1f; /* jb 0x1013fb1f */
            ii(0x1013_faff, 5); cmp(memw_a32[ss, ebp - 0x20], 0x3d);    /* cmp word [ebp-0x20], 0x3d */
            ii(0x1013_fb04, 2); if(jbed(0x1013_fab5, -0x51)) goto l_0x1013_fab5; /* jbe 0x1013fab5 */
            ii(0x1013_fb06, 5); cmp(memw_a32[ss, ebp - 0x20], 0x40);    /* cmp word [ebp-0x20], 0x40 */
            ii(0x1013_fb0b, 2); if(jbd(0x1013_fb1d, 0x10)) goto l_0x1013_fb1d; /* jb 0x1013fb1d */
            ii(0x1013_fb0d, 5); cmp(memw_a32[ss, ebp - 0x20], 0x40);    /* cmp word [ebp-0x20], 0x40 */
            ii(0x1013_fb12, 2); if(jbed(0x1013_fac1, -0x53)) goto l_0x1013_fac1; /* jbe 0x1013fac1 */
            ii(0x1013_fb14, 5); cmp(memw_a32[ss, ebp - 0x20], 0x4b);    /* cmp word [ebp-0x20], 0x4b */
            ii(0x1013_fb19, 2); if(jzd(0x1013_fab5, -0x66)) goto l_0x1013_fab5; /* jz 0x1013fab5 */
            ii(0x1013_fb1b, 2); jmpd(0x1013_fad9, -0x44); goto l_0x1013_fad9; /* jmp 0x1013fad9 */
        l_0x1013_fb1d:
            ii(0x1013_fb1d, 2); jmpd(0x1013_fad9, -0x46); goto l_0x1013_fad9; /* jmp 0x1013fad9 */
        l_0x1013_fb1f:
            ii(0x1013_fb1f, 2); jmpd(0x1013_facd, -0x54); goto l_0x1013_facd; /* jmp 0x1013facd */
        l_0x1013_fb21:
            ii(0x1013_fb21, 5); cmp(memw_a32[ss, ebp - 0x20], 0x7);     /* cmp word [ebp-0x20], 0x7 */
            ii(0x1013_fb26, 2); if(jbd(0x1013_fb45, 0x1d)) goto l_0x1013_fb45; /* jb 0x1013fb45 */
            ii(0x1013_fb28, 5); cmp(memw_a32[ss, ebp - 0x20], 0x7);     /* cmp word [ebp-0x20], 0x7 */
            ii(0x1013_fb2d, 2); if(jbed(0x1013_fac1, -0x6e)) goto l_0x1013_fac1; /* jbe 0x1013fac1 */
            ii(0x1013_fb2f, 5); cmp(memw_a32[ss, ebp - 0x20], 0x8);     /* cmp word [ebp-0x20], 0x8 */
            ii(0x1013_fb34, 2); if(jbed(0x1013_facd, -0x69)) goto l_0x1013_facd; /* jbe 0x1013facd */
            ii(0x1013_fb36, 5); cmp(memw_a32[ss, ebp - 0x20], 0x31);    /* cmp word [ebp-0x20], 0x31 */
            ii(0x1013_fb3b, 6); if(jzd(0x1013_fab5, -0x8c)) goto l_0x1013_fab5; /* jz 0x1013fab5 */
            ii(0x1013_fb41, 2); jmpd(0x1013_fad9, -0x6a); goto l_0x1013_fad9; /* jmp 0x1013fad9 */
        //  ii(0x1013_fb43, 2); Недостижимый код.
l_0x1013_fb45:
            ii(0x1013_fb45, 5); cmp(memw_a32[ss, ebp - 0x20], 0x6);     /* cmp word [ebp-0x20], 0x6 */
            ii(0x1013_fb4a, 6); if(jzd(0x1013_fab5, -0x9b)) goto l_0x1013_fab5; /* jz 0x1013fab5 */
            ii(0x1013_fb50, 2); jmpd(0x1013_fad9, -0x79); goto l_0x1013_fad9; /* jmp 0x1013fad9 */
        l_0x1013_fb52:
            ii(0x1013_fb52, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1013_fb56, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1013_fb5a, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_fb60, 6); mov(eax, memd_a32[ds, eax + 0x101c_a562]); /* mov eax, [eax+0x101ca562] */
            ii(0x1013_fb66, 5); calld(0x100c_b6b0, -0x744bb);           /* call 0x100cb6b0 */
            ii(0x1013_fb6b, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1013_fb6e, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1013_fb73, 1); pushd(eax);                             /* push eax */
            ii(0x1013_fb74, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x1013_fb77, 3); mov(eax, memd_a32[ds, eax + 0x17]);     /* mov eax, [eax+0x17] */
            ii(0x1013_fb7a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_fb7d, 1); pushd(eax);                             /* push eax */
            ii(0x1013_fb7e, 4); movsx(ecx, memw_a32[ss, ebp + 0x14]);   /* movsx ecx, word [ebp+0x14] */
            ii(0x1013_fb82, 5); mov(ebx, 0x101a_cddc);                  /* mov ebx, 0x101acddc */ /* "Cargo" */
            ii(0x1013_fb87, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1013_fb8b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_fb8e, 5); calld(0x1013_f4b0, -0x6e3);             /* call 0x1013f4b0 */
            ii(0x1013_fb93, 3); mov(edx, memd_a32[ss, ebp + 0x10]);     /* mov edx, [ebp+0x10] */
            ii(0x1013_fb96, 3); mov(edx, memd_a32[ds, edx + 0x17]);     /* mov edx, [edx+0x17] */
            ii(0x1013_fb99, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_fb9c, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
            ii(0x1013_fba1, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_fba3, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_fba6, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_fba8, 1); cwde();                                 /* cwde */
            ii(0x1013_fba9, 1); pushd(eax);                             /* push eax */
            ii(0x1013_fbaa, 3); mov(edx, memd_a32[ss, ebp - 0x24]);     /* mov edx, [ebp-0x24] */
            ii(0x1013_fbad, 3); mov(edx, memd_a32[ds, edx + 0x17]);     /* mov edx, [edx+0x17] */
            ii(0x1013_fbb0, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_fbb3, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
            ii(0x1013_fbb8, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_fbba, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_fbbd, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_fbbf, 1); cwde();                                 /* cwde */
            ii(0x1013_fbc0, 1); pushd(eax);                             /* push eax */
            ii(0x1013_fbc1, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1013_fbc5, 1); pushd(eax);                             /* push eax */
            ii(0x1013_fbc6, 4); movsx(ecx, memw_a32[ss, ebp - 0x18]);   /* movsx ecx, word [ebp-0x18] */
            ii(0x1013_fbca, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1013_fbcd, 3); sub(eax, 0x4c);                         /* sub eax, 0x4c */
            ii(0x1013_fbd0, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1013_fbd3, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1013_fbd7, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_fbda, 3); add(eax, 0x4c);                         /* add eax, 0x4c */
            ii(0x1013_fbdd, 5); calld(0x1013_f629, -0x5b9);             /* call 0x1013f629 */
            ii(0x1013_fbe2, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1013_fbe6, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x1013_fbe9, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1013_fbec, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_fbee, 3); mov(memd_a32[ss, ebp - 0x1c], edx);     /* mov [ebp-0x1c], edx */
        l_0x1013_fbf1:
            ii(0x1013_fbf1, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1013_fbf4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_fbf6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_fbf7, 1); popd(edi);                              /* pop edi */
            ii(0x1013_fbf8, 1); popd(esi);                              /* pop esi */
            ii(0x1013_fbf9, 3); retd(0x8); return;                      /* ret 0x8 */
        }
    }
}
