using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_2cba-bd317c7c")]
        public void Method_1015_2cba()
        {
            ii(0x1015_2cba, 5); pushd(0x44);                            /* push 0x44 */
            ii(0x1015_2cbf, 5); calld(Definitions.sys_check_available_stack_size, 0x1_308e); /* call 0x10165d52 */
            ii(0x1015_2cc4, 1); pushd(esi);                             /* push esi */
            ii(0x1015_2cc5, 1); pushd(edi);                             /* push edi */
            ii(0x1015_2cc6, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_2cc7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_2cc9, 6); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x1015_2ccf, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1015_2cd2, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1015_2cd5, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1015_2cd8, 3); mov(memd_a32[ss, ebp - 0x8], ecx);      /* mov [ebp-0x8], ecx */
            ii(0x1015_2cdb, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_2cde, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1015_2ce1, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_2ce4, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1015_2ce6, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1015_2cea, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1015_2cec, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1015_2cef, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1015_2cf1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_2cf3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_2cf6, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1015_2cf9, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1015_2cfb, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1015_2cfe, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_2d01, 3); mov(edx, memd_a32[ds, eax + 0x4]);      /* mov edx, [eax+0x4] */
            ii(0x1015_2d04, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_2d07, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1015_2d09, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1015_2d0d, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1015_2d0f, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1015_2d12, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1015_2d14, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_2d16, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_2d19, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1015_2d1b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_2d1e, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1015_2d20, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1015_2d23, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_2d26, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x1015_2d29, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1015_2d2b, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1015_2d2f, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1015_2d31, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1015_2d34, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1015_2d36, 3); mov(edx, memd_a32[ss, ebp - 0x20]);     /* mov edx, [ebp-0x20] */
            ii(0x1015_2d39, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1015_2d3b, 3); mov(memd_a32[ss, ebp - 0x18], edx);     /* mov [ebp-0x18], edx */
            ii(0x1015_2d3e, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1015_2d41, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1015_2d43, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_2d46, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1015_2d48, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1015_2d4c, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1015_2d4e, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1015_2d51, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1015_2d53, 3); mov(edx, memd_a32[ss, ebp - 0x1c]);     /* mov edx, [ebp-0x1c] */
            ii(0x1015_2d56, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1015_2d58, 3); mov(memd_a32[ss, ebp - 0x14], edx);     /* mov [ebp-0x14], edx */
            ii(0x1015_2d5b, 3); mov(edx, memd_a32[ss, ebp - 0x20]);     /* mov edx, [ebp-0x20] */
            ii(0x1015_2d5e, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x1015_2d61, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1015_2d63, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1015_2d66, 6); idiv(memd_a32[ds, 0x101c_38c4]);        /* idiv dword [0x101c38c4] */
            ii(0x1015_2d6c, 6); mov(edx, memd_a32[ds, 0x101c_38fa]);    /* mov edx, [0x101c38fa] */
            ii(0x1015_2d72, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_2d75, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1015_2d77, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1015_2d7a, 3); mov(edx, memd_a32[ss, ebp - 0x1c]);     /* mov edx, [ebp-0x1c] */
            ii(0x1015_2d7d, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x1015_2d80, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1015_2d82, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1015_2d85, 6); idiv(memd_a32[ds, 0x101c_38c4]);        /* idiv dword [0x101c38c4] */
            ii(0x1015_2d8b, 6); mov(edx, memd_a32[ds, 0x101c_38fc]);    /* mov edx, [0x101c38fc] */
            ii(0x1015_2d91, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_2d94, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1015_2d96, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1015_2d99, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x1015_2d9c, 1); dec(edx);                               /* dec edx */
            ii(0x1015_2d9d, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x1015_2da0, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1015_2da2, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1015_2da5, 6); idiv(memd_a32[ds, 0x101c_38c4]);        /* idiv dword [0x101c38c4] */
            ii(0x1015_2dab, 6); mov(edx, memd_a32[ds, 0x101c_38fa]);    /* mov edx, [0x101c38fa] */
            ii(0x1015_2db1, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_2db4, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1015_2db6, 1); inc(eax);                               /* inc eax */
            ii(0x1015_2db7, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1015_2dba, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x1015_2dbd, 1); dec(edx);                               /* dec edx */
            ii(0x1015_2dbe, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x1015_2dc1, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1015_2dc3, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1015_2dc6, 6); idiv(memd_a32[ds, 0x101c_38c4]);        /* idiv dword [0x101c38c4] */
            ii(0x1015_2dcc, 6); mov(edx, memd_a32[ds, 0x101c_38fc]);    /* mov edx, [0x101c38fc] */
            ii(0x1015_2dd2, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_2dd5, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1015_2dd7, 1); inc(eax);                               /* inc eax */
            ii(0x1015_2dd8, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1015_2ddb, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1015_2dde, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1015_2de0, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1015_2de3, 5); calld(0x1007_6e7c, -0xd_bf6c);          /* call 0x10076e7c */
            ii(0x1015_2de8, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1015_2deb, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1015_2dee, 3); mov(edx, memd_a32[ds, edx + 0x4]);      /* mov edx, [edx+0x4] */
            ii(0x1015_2df1, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1015_2df4, 5); calld(0x1007_6e7c, -0xd_bf7d);          /* call 0x10076e7c */
            ii(0x1015_2df9, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1015_2dfc, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1015_2dff, 3); mov(edx, memd_a32[ds, edx + 0x8]);      /* mov edx, [edx+0x8] */
            ii(0x1015_2e02, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_2e05, 5); calld(Definitions.my_min, -0xc_9686);   /* call 0x10089784 */
            ii(0x1015_2e0a, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1015_2e0d, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1015_2e10, 3); mov(edx, memd_a32[ds, edx + 0xc]);      /* mov edx, [edx+0xc] */
            ii(0x1015_2e13, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1015_2e16, 5); calld(Definitions.my_min, -0xc_9697);   /* call 0x10089784 */
            ii(0x1015_2e1b, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1015_2e1e, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1015_2e21, 3); cmp(eax, memd_a32[ss, ebp - 0x28]);     /* cmp eax, [ebp-0x28] */
            ii(0x1015_2e24, 2); if(jged(0x1015_2e2e, 0x8)) goto l_0x1015_2e2e; /* jge 0x10152e2e */
            ii(0x1015_2e26, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1015_2e29, 3); cmp(eax, memd_a32[ss, ebp - 0x24]);     /* cmp eax, [ebp-0x24] */
            ii(0x1015_2e2c, 2); if(jld(0x1015_2e3a, 0xc)) goto l_0x1015_2e3a; /* jl 0x10152e3a */
        l_0x1015_2e2e:
            ii(0x1015_2e2e, 7); mov(memd_a32[ss, ebp - 0x34], 0);       /* mov dword [ebp-0x34], 0x0 */
            ii(0x1015_2e35, 5); jmpd(0x1015_2f18, 0xde); goto l_0x1015_2f18; /* jmp 0x10152f18 */
        l_0x1015_2e3a:
            ii(0x1015_2e3a, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_2e3d, 3); sub(eax, memd_a32[ss, ebp - 0x20]);     /* sub eax, [ebp-0x20] */
            ii(0x1015_2e40, 6); mov(memw_a32[ds, 0x101c_3654], ax);     /* mov [0x101c3654], ax */
            ii(0x1015_2e46, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1015_2e49, 3); sub(eax, memd_a32[ss, ebp - 0x1c]);     /* sub eax, [ebp-0x1c] */
            ii(0x1015_2e4c, 6); mov(memw_a32[ds, 0x101c_3656], ax);     /* mov [0x101c3656], ax */
            ii(0x1015_2e52, 5); mov(eax, memd_a32[ds, 0x101c_3652]);    /* mov eax, [0x101c3652] */
            ii(0x1015_2e57, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_2e5a, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1015_2e5d, 2); if(jgd(0x1015_2e68, 0x9)) goto l_0x1015_2e68; /* jg 0x10152e68 */
            ii(0x1015_2e5f, 9); mov(memw_a32[ds, 0x101c_3654], 0x2);    /* mov word [0x101c3654], 0x2 */
        l_0x1015_2e68:
            ii(0x1015_2e68, 5); mov(eax, memd_a32[ds, 0x101c_3654]);    /* mov eax, [0x101c3654] */
            ii(0x1015_2e6d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_2e70, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1015_2e73, 2); if(jgd(0x1015_2e7e, 0x9)) goto l_0x1015_2e7e; /* jg 0x10152e7e */
            ii(0x1015_2e75, 9); mov(memw_a32[ds, 0x101c_3656], 0x2);    /* mov word [0x101c3656], 0x2 */
        l_0x1015_2e7e:
            ii(0x1015_2e7e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_2e81, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x1015_2e84, 1); dec(edx);                               /* dec edx */
            ii(0x1015_2e85, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x1015_2e88, 5); mov(eax, memd_a32[ds, 0x101c_3652]);    /* mov eax, [0x101c3652] */
            ii(0x1015_2e8d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_2e90, 3); lea(ebx, eax - 0x1);                    /* lea ebx, [eax-0x1] */
            ii(0x1015_2e93, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1015_2e95, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1015_2e98, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1015_2e9a, 3); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x1015_2e9d, 5); mov(memd_a32[ds, 0x101c_3648], eax);    /* mov [0x101c3648], eax */
            ii(0x1015_2ea2, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1015_2ea5, 2); mov(eax, memd_a32[ds, edx]);            /* mov eax, [edx] */
            ii(0x1015_2ea7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_2eaa, 1); dec(eax);                               /* dec eax */
            ii(0x1015_2eab, 3); shl(eax, 0x10);                         /* shl eax, 0x10 */
            ii(0x1015_2eae, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_2eb0, 5); mov(eax, memd_a32[ds, 0x101c_3654]);    /* mov eax, [0x101c3654] */
            ii(0x1015_2eb5, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_2eb8, 3); lea(ebx, eax - 0x1);                    /* lea ebx, [eax-0x1] */
            ii(0x1015_2ebb, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1015_2ebd, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1015_2ec0, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1015_2ec2, 3); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x1015_2ec5, 5); mov(memd_a32[ds, 0x101c_364c], eax);    /* mov [0x101c364c], eax */
            ii(0x1015_2eca, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1015_2ecd, 3); sub(eax, memd_a32[ss, ebp - 0x20]);     /* sub eax, [ebp-0x20] */
            ii(0x1015_2ed0, 6); mov(memw_a32[ds, 0x101c_3650], ax);     /* mov [0x101c3650], ax */
            ii(0x1015_2ed6, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1015_2ed9, 3); sub(eax, memd_a32[ss, ebp - 0x1c]);     /* sub eax, [ebp-0x1c] */
            ii(0x1015_2edc, 6); mov(memw_a32[ds, 0x101c_3652], ax);     /* mov [0x101c3652], ax */
            ii(0x1015_2ee2, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1015_2ee5, 3); sub(eax, memd_a32[ss, ebp - 0x30]);     /* sub eax, [ebp-0x30] */
            ii(0x1015_2ee8, 6); mov(memw_a32[ds, 0x101c_3654], ax);     /* mov [0x101c3654], ax */
            ii(0x1015_2eee, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1015_2ef1, 3); sub(eax, memd_a32[ss, ebp - 0x2c]);     /* sub eax, [ebp-0x2c] */
            ii(0x1015_2ef4, 6); mov(memw_a32[ds, 0x101c_3656], ax);     /* mov [0x101c3656], ax */
            ii(0x1015_2efa, 5); mov(eax, memd_a32[ds, 0x101b_7f5a]);    /* mov eax, [0x101b7f5a] */
            ii(0x1015_2eff, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_2f02, 4); imul(eax, memd_a32[ss, ebp - 0x2c]);    /* imul eax, [ebp-0x2c] */
            ii(0x1015_2f06, 3); mov(edx, memd_a32[ss, ebp - 0x30]);     /* mov edx, [ebp-0x30] */
            ii(0x1015_2f09, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1015_2f0b, 6); mov(memd_a32[ds, 0x101c_3638], edx);    /* mov [0x101c3638], edx */
            ii(0x1015_2f11, 7); mov(memd_a32[ss, ebp - 0x34], 0x1);     /* mov dword [ebp-0x34], 0x1 */
        l_0x1015_2f18:
            ii(0x1015_2f18, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1015_2f1b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_2f1d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_2f1e, 1); popd(edi);                              /* pop edi */
            ii(0x1015_2f1f, 1); popd(esi);                              /* pop esi */
            ii(0x1015_2f20, 1); retd();                                 /* ret */
        }
    }
}
