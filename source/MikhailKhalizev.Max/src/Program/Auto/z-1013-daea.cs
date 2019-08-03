using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c613dd07-c881-4243-ab59-a7701fb4f7f7")]
        public void Method_1013_daea()
        {
            ii(0x1013_daea, 5); pushd(0x4c);                            /* push 0x4c */
            ii(0x1013_daef, 5); calld(Definitions.sys_check_available_stack_size, 0x2825e); /* call 0x10165d52 */
            ii(0x1013_daf4, 1); pushd(esi);                             /* push esi */
            ii(0x1013_daf5, 1); pushd(edi);                             /* push edi */
            ii(0x1013_daf6, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_daf7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_daf9, 6); sub(esp, 0x3c);                         /* sub esp, 0x3c */
            ii(0x1013_daff, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_db02, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1013_db05, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1013_db08, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x1013_db0b, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1013_db0f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_db11, 2); if(jged(0x1013_db28, 0x15)) goto l_0x1013_db28; /* jge 0x1013db28 */
            ii(0x1013_db13, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x1013_db17, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1013_db1b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_db1e, 5); calld(0x1013_d9eb, -0x138);             /* call 0x1013d9eb */
            ii(0x1013_db23, 5); jmpd(0x1013_dc53, 0x12b); goto l_0x1013_dc53; /* jmp 0x1013dc53 */
        l_0x1013_db28:
            ii(0x1013_db28, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x1013_db2c, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1013_db30, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_db33, 5); calld(0x1013_d910, -0x228);             /* call 0x1013d910 */
            ii(0x1013_db38, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_db3a, 6); if(jnzd(0x1013_dc53, 0x113)) goto l_0x1013_dc53; /* jnz 0x1013dc53 */
            ii(0x1013_db40, 5); mov(eax, 0x3b);                         /* mov eax, 0x3b */
            ii(0x1013_db45, 5); calld(0x1007_5fdc, -0xc7b6e);           /* call 0x10075fdc */
            ii(0x1013_db4a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_db4c, 6); if(jnzd(0x1013_dc53, 0x101)) goto l_0x1013_dc53; /* jnz 0x1013dc53 */
            ii(0x1013_db52, 5); cmp(memw_a32[ss, ebp - 0x4], 0);        /* cmp word [ebp-0x4], 0x0 */
            ii(0x1013_db57, 2); if(jzd(0x1013_db61, 0x8)) goto l_0x1013_db61; /* jz 0x1013db61 */
            ii(0x1013_db59, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_db5c, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1013_db5f, 2); jmpd(0x1013_db71, 0x10); goto l_0x1013_db71; /* jmp 0x1013db71 */
        l_0x1013_db61:
            ii(0x1013_db61, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1013_db65, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1013_db67, 7); mov(ax, memw_a32[ds, eax + 0x101b_ce2e]); /* mov ax, [eax+0x101bce2e] */
            ii(0x1013_db6e, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
        l_0x1013_db71:
            ii(0x1013_db71, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1013_db75, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1013_db79, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1013_db7b, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_db7d, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_db80, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1013_db82, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1013_db84, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_db86, 5); calld(/* sys */ 0x1016_5e9b, 0x28310);  /* call 0x10165e9b */
            ii(0x1013_db8b, 1); inc(edx);                               /* inc edx */
            ii(0x1013_db8c, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1013_db8f, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x1013_db92, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1013_db95, 3); mov(edx, memd_a32[ss, ebp - 0x1c]);     /* mov edx, [ebp-0x1c] */
            ii(0x1013_db98, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1013_db9a, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1013_db9e, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_dba0, 3); mov(memd_a32[ss, ebp - 0x1c], edx);     /* mov [ebp-0x1c], edx */
            ii(0x1013_dba3, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1013_dba6, 3); inc(memd_a32[ss, ebp - 0x1c]);          /* inc dword [ebp-0x1c] */
            ii(0x1013_dba9, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1013_dbb0, 2); jmpd(0x1013_dbb8, 0x6); goto l_0x1013_dbb8; /* jmp 0x1013dbb8 */
        l_0x1013_dbb2:
            ii(0x1013_dbb2, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1013_dbb5, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
        l_0x1013_dbb8:
            ii(0x1013_dbb8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_dbba, 5); mov(al, memb_a32[ds, 0x101c_7298]);     /* mov al, [0x101c7298] */
            ii(0x1013_dbbf, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1013_dbc3, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1013_dbc5, 2); if(jged(0x1013_dc04, 0x3d)) goto l_0x1013_dc04; /* jge 0x1013dc04 */
            ii(0x1013_dbc7, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1013_dbcb, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1013_dbce, 5); mov(edx, 0x101c_7299);                  /* mov edx, 0x101c7299 */
            ii(0x1013_dbd3, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_dbd5, 3); mov(memd_a32[ss, ebp - 0x20], edx);     /* mov [ebp-0x20], edx */
            ii(0x1013_dbd8, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1013_dbdb, 4); cmp(memb_a32[ds, eax + 0xa], 0x3);      /* cmp byte [eax+0xa], 0x3 */
            ii(0x1013_dbdf, 2); if(jnzd(0x1013_dc02, 0x21)) goto l_0x1013_dc02; /* jnz 0x1013dc02 */
            ii(0x1013_dbe1, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1013_dbe4, 3); mov(edx, memd_a32[ss, ebp - 0x20]);     /* mov edx, [ebp-0x20] */
            ii(0x1013_dbe7, 4); cmp(ax, memw_a32[ds, edx + 0x17]);      /* cmp ax, [edx+0x17] */
            ii(0x1013_dbeb, 2); if(jld(0x1013_dc00, 0x13)) goto l_0x1013_dc00; /* jl 0x1013dc00 */
            ii(0x1013_dbed, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1013_dbf0, 3); mov(edx, memd_a32[ss, ebp - 0x20]);     /* mov edx, [ebp-0x20] */
            ii(0x1013_dbf3, 3); mov(memw_a32[ds, edx], ax);             /* mov [edx], ax */
            ii(0x1013_dbf6, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1013_dbf9, 3); mov(edx, memd_a32[ss, ebp - 0x20]);     /* mov edx, [ebp-0x20] */
            ii(0x1013_dbfc, 4); mov(memw_a32[ds, edx + 0x17], ax);      /* mov [edx+0x17], ax */
        l_0x1013_dc00:
            ii(0x1013_dc00, 2); jmpd(0x1013_dc53, 0x51); goto l_0x1013_dc53; /* jmp 0x1013dc53 */
        l_0x1013_dc02:
            ii(0x1013_dc02, 2); jmpd(0x1013_dbb2, -0x52); goto l_0x1013_dbb2; /* jmp 0x1013dbb2 */
        l_0x1013_dc04:
            ii(0x1013_dc04, 4); mov(memb_a32[ss, ebp - 0x32], 0x3);     /* mov byte [ebp-0x32], 0x3 */
            ii(0x1013_dc08, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1013_dc0b, 4); mov(memw_a32[ss, ebp - 0x3c], ax);      /* mov [ebp-0x3c], ax */
            ii(0x1013_dc0f, 7); mov(memd_a32[ss, ebp - 0x3a], 0x7fff);  /* mov dword [ebp-0x3a], 0x7fff */
            ii(0x1013_dc16, 7); mov(memd_a32[ss, ebp - 0x36], 0x7fff);  /* mov dword [ebp-0x36], 0x7fff */
            ii(0x1013_dc1d, 7); mov(memd_a32[ss, ebp - 0x31], 0x8000);  /* mov dword [ebp-0x31], 0x8000 */
            ii(0x1013_dc24, 7); mov(memd_a32[ss, ebp - 0x2d], 0);       /* mov dword [ebp-0x2d], 0x0 */
            ii(0x1013_dc2b, 6); mov(memw_a32[ss, ebp - 0x29], 0);       /* mov word [ebp-0x29], 0x0 */
            ii(0x1013_dc31, 6); mov(memw_a32[ss, ebp - 0x27], 0);       /* mov word [ebp-0x27], 0x0 */
            ii(0x1013_dc37, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1013_dc3a, 4); mov(memw_a32[ss, ebp - 0x25], ax);      /* mov [ebp-0x25], ax */
            ii(0x1013_dc3e, 4); mov(memb_a32[ss, ebp - 0x23], 0);       /* mov byte [ebp-0x23], 0x0 */
            ii(0x1013_dc42, 6); mov(memw_a32[ss, ebp - 0x22], 0xffff);  /* mov word [ebp-0x22], 0xffff */
            ii(0x1013_dc48, 3); lea(edx, ebp - 0x3c);                   /* lea edx, [ebp-0x3c] */
            ii(0x1013_dc4b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_dc4e, 5); calld(0x1013_dfd1, 0x37e);              /* call 0x1013dfd1 */
        l_0x1013_dc53:
            ii(0x1013_dc53, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_dc55, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_dc56, 1); popd(edi);                              /* pop edi */
            ii(0x1013_dc57, 1); popd(esi);                              /* pop esi */
            ii(0x1013_dc58, 1); retd(); return;                         /* ret */
        }
    }
}
