using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_fbc0-5dd8dfd5")]
        public void Method_100e_fbc0()
        {
            ii(0x100e_fbc0, 5); pushd(0x40);                            /* push 0x40 */
            ii(0x100e_fbc5, 5); calld(Definitions.sys_check_available_stack_size, 0x7_6188); /* call 0x10165d52 */
            ii(0x100e_fbca, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_fbcb, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_fbcc, 1); pushd(esi);                             /* push esi */
            ii(0x100e_fbcd, 1); pushd(edi);                             /* push edi */
            ii(0x100e_fbce, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_fbcf, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_fbd1, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x100e_fbd7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_fbda, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_fbdd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_fbe0, 4); add(memd_a32[ss, ebp - 0x8], 0x2);      /* add dword [ebp-0x8], 0x2 */
            ii(0x100e_fbe4, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100e_fbe7, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_fbea, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_fbed, 3); mov(eax, memd_a32[ds, eax + 0x4c]);     /* mov eax, [eax+0x4c] */
            ii(0x100e_fbf0, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
        l_0x100e_fbf3:
            ii(0x100e_fbf3, 3); dec(memd_a32[ss, ebp - 0xc]);           /* dec dword [ebp-0xc] */
            ii(0x100e_fbf6, 5); cmp(memw_a32[ss, ebp - 0xc], -0x1 /* 0xff */); /* cmp word [ebp-0xc], 0xffff */
            ii(0x100e_fbfb, 6); if(jzd(0x100e_fd15, 0x114)) goto l_0x100e_fd15; /* jz 0x100efd15 */
            ii(0x100e_fc01, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_fc04, 4); add(memd_a32[ss, ebp - 0x8], 0x2);      /* add dword [ebp-0x8], 0x2 */
            ii(0x100e_fc08, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100e_fc0b, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
        l_0x100e_fc0e:
            ii(0x100e_fc0e, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100e_fc12, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_fc14, 2); if(jged(0x100e_fc55, 0x3f)) goto l_0x100e_fc55; /* jge 0x100efc55 */
            ii(0x100e_fc16, 6); test(memw_a32[ss, ebp - 0x14], 0x4000); /* test word [ebp-0x14], 0x4000 */
            ii(0x100e_fc1c, 2); if(jzd(0x100e_fc33, 0x15)) goto l_0x100e_fc33; /* jz 0x100efc33 */
            ii(0x100e_fc1e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_fc21, 3); mov(eax, memd_a32[ds, eax + 0x67]);     /* mov eax, [eax+0x67] */
            ii(0x100e_fc24, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_fc27, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x100e_fc2b, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100e_fc2e, 3); sub(memd_a32[ss, ebp - 0x10], eax);     /* sub [ebp-0x10], eax */
            ii(0x100e_fc31, 2); jmpd(0x100e_fc45, 0x12); goto l_0x100e_fc45; /* jmp 0x100efc45 */
        l_0x100e_fc33:
            ii(0x100e_fc33, 3); mov(dl, memb_a32[ss, ebp - 0x14]);      /* mov dl, [ebp-0x14] */
            ii(0x100e_fc36, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_fc39, 3); mov(eax, memd_a32[ds, eax + 0x61]);     /* mov eax, [eax+0x61] */
            ii(0x100e_fc3c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_fc3f, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x100e_fc42, 3); mov(memb_a32[ds, eax - 0x1], dl);       /* mov [eax-0x1], dl */
        l_0x100e_fc45:
            ii(0x100e_fc45, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_fc48, 4); add(memd_a32[ss, ebp - 0x8], 0x2);      /* add dword [ebp-0x8], 0x2 */
            ii(0x100e_fc4c, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100e_fc4f, 4); mov(memw_a32[ss, ebp - 0x14], ax);      /* mov [ebp-0x14], ax */
            ii(0x100e_fc53, 2); jmpd(0x100e_fc0e, -0x47); goto l_0x100e_fc0e; /* jmp 0x100efc0e */
        l_0x100e_fc55:
            ii(0x100e_fc55, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
        l_0x100e_fc5c:
            ii(0x100e_fc5c, 4); dec(memw_a32[ss, ebp - 0x14]);          /* dec word [ebp-0x14] */
            ii(0x100e_fc60, 5); cmp(memw_a32[ss, ebp - 0x14], -0x1 /* 0xff */); /* cmp word [ebp-0x14], 0xffff */
            ii(0x100e_fc65, 6); if(jzd(0x100e_fd04, 0x99)) goto l_0x100e_fd04; /* jz 0x100efd04 */
            ii(0x100e_fc6b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_fc6e, 4); add(memd_a32[ss, ebp - 0x8], 0x2);      /* add dword [ebp-0x8], 0x2 */
            ii(0x100e_fc72, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100e_fc75, 4); mov(memw_a32[ss, ebp - 0x1c], ax);      /* mov [ebp-0x1c], ax */
            ii(0x100e_fc79, 3); mov(al, memb_a32[ss, ebp - 0x1c]);      /* mov al, [ebp-0x1c] */
            ii(0x100e_fc7c, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100e_fc7e, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100e_fc81, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100e_fc84, 3); add(memd_a32[ss, ebp - 0x18], eax);     /* add [ebp-0x18], eax */
            ii(0x100e_fc87, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100e_fc8b, 3); sar(eax, 0x8);                          /* sar eax, 0x8 */
            ii(0x100e_fc8e, 2); cbw();                                  /* cbw */
            ii(0x100e_fc90, 4); mov(memw_a32[ss, ebp - 0x1c], ax);      /* mov [ebp-0x1c], ax */
            ii(0x100e_fc94, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100e_fc98, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_fc9a, 2); if(jld(0x100e_fcc4, 0x28)) goto l_0x100e_fcc4; /* jl 0x100efcc4 */
            ii(0x100e_fc9c, 4); movsx(ebx, memw_a32[ss, ebp - 0x1c]);   /* movsx ebx, word [ebp-0x1c] */
            ii(0x100e_fca0, 2); add(ebx, ebx);                          /* add ebx, ebx */
            ii(0x100e_fca2, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_fca5, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x100e_fca9, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x100e_fcac, 5); calld(Definitions.sys_memcpy, 0x7_619a); /* call 0x10165e4b */
            ii(0x100e_fcb1, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100e_fcb5, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100e_fcb7, 3); add(memd_a32[ss, ebp - 0x8], eax);      /* add [ebp-0x8], eax */
            ii(0x100e_fcba, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100e_fcbd, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100e_fcbf, 3); add(memd_a32[ss, ebp - 0x18], eax);     /* add [ebp-0x18], eax */
            ii(0x100e_fcc2, 2); jmpd(0x100e_fcff, 0x3b); goto l_0x100e_fcff; /* jmp 0x100efcff */
        l_0x100e_fcc4:
            ii(0x100e_fcc4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_fcc7, 4); add(memd_a32[ss, ebp - 0x8], 0x2);      /* add dword [ebp-0x8], 0x2 */
            ii(0x100e_fccb, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100e_fcce, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100e_fcd1, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x100e_fcd5, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100e_fcd8, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_fcda, 3); mov(memd_a32[ss, ebp - 0x28], edx);     /* mov [ebp-0x28], edx */
            ii(0x100e_fcdd, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100e_fce0, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100e_fce2, 3); sub(memd_a32[ss, ebp - 0x18], eax);     /* sub [ebp-0x18], eax */
        l_0x100e_fce5:
            ii(0x100e_fce5, 4); inc(memw_a32[ss, ebp - 0x1c]);          /* inc word [ebp-0x1c] */
            ii(0x100e_fce9, 5); cmp(memw_a32[ss, ebp - 0x1c], 0x1);     /* cmp word [ebp-0x1c], 0x1 */
            ii(0x100e_fcee, 2); if(jzd(0x100e_fcff, 0xf)) goto l_0x100e_fcff; /* jz 0x100efcff */
            ii(0x100e_fcf0, 3); mov(edx, memd_a32[ss, ebp - 0x28]);     /* mov edx, [ebp-0x28] */
            ii(0x100e_fcf3, 4); add(memd_a32[ss, ebp - 0x28], 0x2);     /* add dword [ebp-0x28], 0x2 */
            ii(0x100e_fcf7, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100e_fcfa, 3); mov(memw_a32[ds, edx], ax);             /* mov [edx], ax */
            ii(0x100e_fcfd, 2); jmpd(0x100e_fce5, -0x1a); goto l_0x100e_fce5; /* jmp 0x100efce5 */
        l_0x100e_fcff:
            ii(0x100e_fcff, 5); jmpd(0x100e_fc5c, -0xa8); goto l_0x100e_fc5c; /* jmp 0x100efc5c */
        l_0x100e_fd04:
            ii(0x100e_fd04, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_fd07, 3); mov(eax, memd_a32[ds, eax + 0x67]);     /* mov eax, [eax+0x67] */
            ii(0x100e_fd0a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_fd0d, 3); add(memd_a32[ss, ebp - 0x10], eax);     /* add [ebp-0x10], eax */
            ii(0x100e_fd10, 5); jmpd(0x100e_fbf3, -0x122); goto l_0x100e_fbf3; /* jmp 0x100efbf3 */
        l_0x100e_fd15:
            ii(0x100e_fd15, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_fd17, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_fd18, 1); popd(edi);                              /* pop edi */
            ii(0x100e_fd19, 1); popd(esi);                              /* pop esi */
            ii(0x100e_fd1a, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_fd1b, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_fd1c, 1); retd(); return;                         /* ret */
        }
    }
}
