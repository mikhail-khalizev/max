using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_c2ed-1c1fa269")]
        public void Method_1011_c2ed()
        {
            ii(0x1011_c2ed, 5); pushd(0x4c);                            /* push 0x4c */
            ii(0x1011_c2f2, 5); calld(Definitions.sys_check_available_stack_size, 0x4_9a5b); /* call 0x10165d52 */
            ii(0x1011_c2f7, 1); pushd(esi);                             /* push esi */
            ii(0x1011_c2f8, 1); pushd(edi);                             /* push edi */
            ii(0x1011_c2f9, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_c2fa, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_c2fc, 6); sub(esp, 0x3c);                         /* sub esp, 0x3c */
            ii(0x1011_c302, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_c305, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1011_c308, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1011_c30b, 3); mov(memb_a32[ss, ebp - 0x4], cl);       /* mov [ebp-0x4], cl */
            ii(0x1011_c30e, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1011_c311, 5); calld(Definitions.my_ctor_0x101b_4184, -0xa_5826); /* call 0x10076af0 */
            ii(0x1011_c316, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_c319, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1011_c31c, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_c31f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_c321, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_c324, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_c326, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_c328, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_c32b, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_c32d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_c330, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_c332, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1011_c334, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_c336, 3); mov(memd_a32[ss, ebp - 0x18], edx);     /* mov [ebp-0x18], edx */
            ii(0x1011_c339, 6); inc(memd_a32[ds, 0x101c_52f8]);         /* inc dword [0x101c52f8] */
            ii(0x1011_c33f, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1011_c342, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1011_c345, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x1011_c349, 2); if(jgd(0x1011_c3b3, 0x68)) goto l_0x1011_c3b3; /* jg 0x1011c3b3 */
            ii(0x1011_c34b, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1011_c34e, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1011_c351, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x1011_c355, 6); if(jld(0x1011_c63c, 0x2e1)) goto l_0x1011_c63c; /* jl 0x1011c63c */
            ii(0x1011_c35b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_c35e, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1011_c361, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_c364, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1011_c366, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_c369, 3); mov(edx, memd_a32[ds, eax + 0x4]);      /* mov edx, [eax+0x4] */
            ii(0x1011_c36c, 2); add(edx, ebx);                          /* add edx, ebx */
            ii(0x1011_c36e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_c371, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_c373, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_c376, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1011_c378, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_c37a, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1011_c37d, 2); mov(memb_a32[ds, edx], al);             /* mov [edx], al */
            ii(0x1011_c37f, 5); mov(eax, memd_a32[ds, 0x101c_52e2]);    /* mov eax, [0x101c52e2] */
            ii(0x1011_c384, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_c387, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1011_c38a, 2); if(jld(0x1011_c3ae, 0x22)) goto l_0x1011_c3ae; /* jl 0x1011c3ae */
            ii(0x1011_c38c, 6); mov(ecx, memd_a32[ds, 0x101b_afce]);    /* mov ecx, [0x101bafce] */
            ii(0x1011_c392, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1011_c395, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_c398, 2); mov(ebx, memd_a32[ds, eax]);            /* mov ebx, [eax] */
            ii(0x1011_c39a, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_c39d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_c3a0, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x1011_c3a3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_c3a5, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1011_c3a8, 1); cwde();                                 /* cwde */
            ii(0x1011_c3a9, 5); calld(0x1011_bdd9, -0x5d5);             /* call 0x1011bdd9 */
        l_0x1011_c3ae:
            ii(0x1011_c3ae, 5); jmpd(0x1011_c63c, 0x289); goto l_0x1011_c63c; /* jmp 0x1011c63c */
        l_0x1011_c3b3:
            ii(0x1011_c3b3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_c3b6, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x1011_c3b9, 3); mov(memw_a32[ds, edx], ax);             /* mov [edx], ax */
            ii(0x1011_c3bc, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_c3bf, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x1011_c3c2, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1011_c3c5, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_c3c8, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x1011_c3cb, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_c3cd, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_c3d0, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_c3d2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_c3d5, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1011_c3d7, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_c3d9, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1011_c3dc, 2); mov(memb_a32[ds, edx], al);             /* mov [edx], al */
            ii(0x1011_c3de, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_c3e1, 3); mov(edx, memd_a32[ds, eax + 0x1c]);     /* mov edx, [eax+0x1c] */
            ii(0x1011_c3e4, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_c3e7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_c3ea, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1011_c3ed, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1011_c3ef, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_c3f1, 5); calld(/* sys */ 0x1016_5df8, 0x4_9a02); /* call 0x10165df8 */
            ii(0x1011_c3f6, 4); mov(memw_a32[ss, ebp - 0x14], ax);      /* mov [ebp-0x14], ax */
            ii(0x1011_c3fa, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_c3fd, 3); mov(edx, memd_a32[ds, eax + 0x1e]);     /* mov edx, [eax+0x1e] */
            ii(0x1011_c400, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_c403, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_c406, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_c408, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_c40b, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1011_c40d, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_c40f, 5); calld(/* sys */ 0x1016_5df8, 0x4_99e4); /* call 0x10165df8 */
            ii(0x1011_c414, 4); mov(memw_a32[ss, ebp - 0x12], ax);      /* mov [ebp-0x12], ax */
            ii(0x1011_c418, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1011_c41b, 4); cmp(ax, memw_a32[ss, ebp - 0x12]);      /* cmp ax, [ebp-0x12] */
            ii(0x1011_c41f, 2); if(jled(0x1011_c430, 0xf)) goto l_0x1011_c430; /* jle 0x1011c430 */
            ii(0x1011_c421, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1011_c424, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_c426, 3); mov(edx, memd_a32[ss, ebp - 0x12]);     /* mov edx, [ebp-0x12] */
            ii(0x1011_c429, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_c42b, 3); mov(memd_a32[ss, ebp - 0x1c], edx);     /* mov [ebp-0x1c], edx */
            ii(0x1011_c42e, 2); jmpd(0x1011_c43d, 0xd); goto l_0x1011_c43d; /* jmp 0x1011c43d */
        l_0x1011_c430:
            ii(0x1011_c430, 3); mov(eax, memd_a32[ss, ebp - 0x12]);     /* mov eax, [ebp-0x12] */
            ii(0x1011_c433, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_c435, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x1011_c438, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_c43a, 3); mov(memd_a32[ss, ebp - 0x1c], edx);     /* mov [ebp-0x1c], edx */
        l_0x1011_c43d:
            ii(0x1011_c43d, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x1011_c440, 3); mov(eax, memd_a32[ds, eax + 0xa]);      /* mov eax, [eax+0xa] */
            ii(0x1011_c443, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_c446, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1011_c44a, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1011_c44c, 2); if(jgd(0x1011_c466, 0x18)) goto l_0x1011_c466; /* jg 0x1011c466 */
            ii(0x1011_c44e, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1011_c452, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_c454, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_c456, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x1011_c459, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x1011_c45c, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_c45e, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1011_c461, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1011_c464, 2); jmpd(0x1011_c490, 0x2a); goto l_0x1011_c490; /* jmp 0x1011c490 */
        l_0x1011_c466:
            ii(0x1011_c466, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x1011_c469, 3); mov(edx, memd_a32[ds, eax + 0xa]);      /* mov edx, [eax+0xa] */
            ii(0x1011_c46c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_c46f, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1011_c471, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x1011_c474, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x1011_c477, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_c479, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1011_c47c, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1011_c47f, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x1011_c482, 3); mov(edx, memd_a32[ss, ebp - 0x1c]);     /* mov edx, [ebp-0x1c] */
            ii(0x1011_c485, 4); sub(dx, memw_a32[ds, eax + 0xc]);       /* sub dx, [eax+0xc] */
            ii(0x1011_c489, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_c48b, 2); and(al, 0xfe);                          /* and al, 0xfe */
            ii(0x1011_c48d, 3); add(memd_a32[ss, ebp - 0x20], eax);     /* add [ebp-0x20], eax */
        l_0x1011_c490:
            ii(0x1011_c490, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_c493, 3); mov(edx, memd_a32[ds, eax + 0x1c]);     /* mov edx, [eax+0x1c] */
            ii(0x1011_c496, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_c499, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1011_c49c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_c49f, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_c4a1, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_c4a3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_c4a6, 3); mov(eax, memd_a32[ds, eax + 0x1e]);     /* mov eax, [eax+0x1e] */
            ii(0x1011_c4a9, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_c4ac, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_c4ae, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1011_c4b0, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_c4b2, 3); mov(memd_a32[ss, ebp - 0x24], edx);     /* mov [ebp-0x24], edx */
            ii(0x1011_c4b5, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1011_c4b9, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x1011_c4bd, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_c4bf, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1011_c4c2, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1011_c4c5, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1011_c4c7, 6); if(jgd(0x1011_c63c, 0x16f)) goto l_0x1011_c63c; /* jg 0x1011c63c */
            ii(0x1011_c4cd, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_c4d0, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1011_c4d3, 5); calld(Definitions.my_3_get_count, -0x9_1058); /* call 0x1008b480 */
            ii(0x1011_c4d8, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1011_c4db, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x1011_c4df, 6); mov(edx, memd_a32[ds, 0x101c_52fa]);    /* mov edx, [0x101c52fa] */
            ii(0x1011_c4e5, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_c4e8, 1); inc(eax);                               /* inc eax */
            ii(0x1011_c4e9, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1011_c4eb, 2); if(jled(0x1011_c4f7, 0xa)) goto l_0x1011_c4f7; /* jle 0x1011c4f7 */
            ii(0x1011_c4ed, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1011_c4f0, 1); inc(eax);                               /* inc eax */
            ii(0x1011_c4f1, 6); mov(memw_a32[ds, 0x101c_52fc], ax);     /* mov [0x101c52fc], ax */
        l_0x1011_c4f7:
            ii(0x1011_c4f7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_c4fa, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x1011_c4fd, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1011_c500, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x1011_c503, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_c505, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_c507, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_c50a, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_c50c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_c50f, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_c511, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1011_c513, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_c515, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1011_c518, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1011_c51c, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_c51e, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1011_c521, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1011_c524, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1011_c526, 2); if(jged(0x1011_c556, 0x2e)) goto l_0x1011_c556; /* jge 0x1011c556 */
            ii(0x1011_c528, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_c52b, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1011_c52e, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_c531, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1011_c533, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x1011_c536, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1011_c538, 2); add(edx, ebx);                          /* add edx, ebx */
            ii(0x1011_c53a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_c53d, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_c53f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_c542, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_c544, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1011_c546, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_c548, 3); mov(dx, memw_a32[ds, eax]);             /* mov dx, [eax] */
            ii(0x1011_c54b, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1011_c54e, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1011_c551, 2); add(ebx, edx);                          /* add ebx, edx */
            ii(0x1011_c553, 3); mov(memw_a32[ds, eax], bx);             /* mov [eax], bx */
        l_0x1011_c556:
            ii(0x1011_c556, 6); inc(memd_a32[ds, 0x101c_52f0]);         /* inc dword [0x101c52f0] */
            ii(0x1011_c55c, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x1011_c560, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_c562, 2); if(jled(0x1011_c5bb, 0x57)) goto l_0x1011_c5bb; /* jle 0x1011c5bb */
            ii(0x1011_c564, 7); mov(memd_a32[ss, ebp - 0x2c], 0);       /* mov dword [ebp-0x2c], 0x0 */
            ii(0x1011_c56b, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1011_c56e, 1); dec(eax);                               /* dec eax */
            ii(0x1011_c56f, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
        l_0x1011_c572:
            ii(0x1011_c572, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1011_c575, 4); cmp(ax, memw_a32[ss, ebp - 0x30]);      /* cmp ax, [ebp-0x30] */
            ii(0x1011_c579, 2); if(jged(0x1011_c5b5, 0x3a)) goto l_0x1011_c5b5; /* jge 0x1011c5b5 */
            ii(0x1011_c57b, 4); movsx(eax, memw_a32[ss, ebp - 0x2c]);   /* movsx eax, word [ebp-0x2c] */
            ii(0x1011_c57f, 4); movsx(edx, memw_a32[ss, ebp - 0x30]);   /* movsx edx, word [ebp-0x30] */
            ii(0x1011_c583, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_c585, 1); inc(eax);                               /* inc eax */
            ii(0x1011_c586, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1011_c588, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1011_c58b, 4); movsx(edx, memw_a32[ss, ebp - 0x34]);   /* movsx edx, word [ebp-0x34] */
            ii(0x1011_c58f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_c592, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1011_c595, 5); calld(0x1012_0548, 0x3fae);             /* call 0x10120548 */
            ii(0x1011_c59a, 4); mov(ax, memw_a32[ds, eax + 0x4]);       /* mov ax, [eax+0x4] */
            ii(0x1011_c59e, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x1011_c5a2, 2); if(jged(0x1011_c5ad, 0x9)) goto l_0x1011_c5ad; /* jge 0x1011c5ad */
            ii(0x1011_c5a4, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1011_c5a7, 1); dec(eax);                               /* dec eax */
            ii(0x1011_c5a8, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1011_c5ab, 2); jmpd(0x1011_c5b3, 0x6); goto l_0x1011_c5b3; /* jmp 0x1011c5b3 */
        l_0x1011_c5ad:
            ii(0x1011_c5ad, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1011_c5b0, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
        l_0x1011_c5b3:
            ii(0x1011_c5b3, 2); jmpd(0x1011_c572, -0x43); goto l_0x1011_c572; /* jmp 0x1011c572 */
        l_0x1011_c5b5:
            ii(0x1011_c5b5, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1011_c5b8, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
        l_0x1011_c5bb:
            ii(0x1011_c5bb, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_c5be, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1011_c5c1, 5); calld(Definitions.my_3_get_count, -0x9_1146); /* call 0x1008b480 */
            ii(0x1011_c5c6, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_c5c9, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x1011_c5cd, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1011_c5cf, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_c5d1, 6); add(memd_a32[ds, 0x101c_52f4], eax);    /* add [0x101c52f4], eax */
            ii(0x1011_c5d7, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1011_c5da, 5); calld(0x1012_04a4, 0x3ec5);             /* call 0x101204a4 */
            ii(0x1011_c5df, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_c5e2, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1011_c5e5, 4); mov(memw_a32[ss, ebp - 0x3c], ax);      /* mov [ebp-0x3c], ax */
            ii(0x1011_c5e9, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_c5ec, 4); mov(ax, memw_a32[ds, eax + 0x2]);       /* mov ax, [eax+0x2] */
            ii(0x1011_c5f0, 4); mov(memw_a32[ss, ebp - 0x3a], ax);      /* mov [ebp-0x3a], ax */
            ii(0x1011_c5f4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_c5f7, 4); mov(memw_a32[ss, ebp - 0x38], ax);      /* mov [ebp-0x38], ax */
            ii(0x1011_c5fb, 4); movsx(ebx, memw_a32[ss, ebp - 0x28]);   /* movsx ebx, word [ebp-0x28] */
            ii(0x1011_c5ff, 3); lea(edx, ebp - 0x3c);                   /* lea edx, [ebp-0x3c] */
            ii(0x1011_c602, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_c605, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1011_c608, 5); calld(0x1012_05bc, 0x3faf);             /* call 0x101205bc */
            ii(0x1011_c60d, 5); mov(eax, memd_a32[ds, 0x101c_52e2]);    /* mov eax, [0x101c52e2] */
            ii(0x1011_c612, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_c615, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1011_c618, 2); if(jld(0x1011_c63c, 0x22)) goto l_0x1011_c63c; /* jl 0x1011c63c */
            ii(0x1011_c61a, 6); mov(ecx, memd_a32[ds, 0x101b_afce]);    /* mov ecx, [0x101bafce] */
            ii(0x1011_c620, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1011_c623, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_c626, 2); mov(ebx, memd_a32[ds, eax]);            /* mov ebx, [eax] */
            ii(0x1011_c628, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_c62b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_c62e, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x1011_c631, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_c633, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1011_c636, 1); cwde();                                 /* cwde */
            ii(0x1011_c637, 5); calld(0x1011_bdd9, -0x863);             /* call 0x1011bdd9 */
        l_0x1011_c63c:
            ii(0x1011_c63c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_c63e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_c63f, 1); popd(edi);                              /* pop edi */
            ii(0x1011_c640, 1); popd(esi);                              /* pop esi */
            ii(0x1011_c641, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}
