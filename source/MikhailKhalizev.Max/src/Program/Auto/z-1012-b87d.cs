using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2da4f5a9-4f99-4121-bb66-07d9132d2c6e")]
        public void Method_1012_b87d()
        {
            ii(0x1012_b87d, 5); pushd(0x5c);                            /* push 0x5c */
            ii(0x1012_b882, 5); calld(Definitions.sys_check_available_stack_size, 0x3_a4cb); /* call 0x10165d52 */
            ii(0x1012_b887, 1); pushd(esi);                             /* push esi */
            ii(0x1012_b888, 1); pushd(edi);                             /* push edi */
            ii(0x1012_b889, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_b88a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_b88c, 6); sub(esp, 0x4c);                         /* sub esp, 0x4c */
            ii(0x1012_b892, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1012_b895, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1012_b898, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1012_b89b, 3); mov(memd_a32[ss, ebp - 0x8], ecx);      /* mov [ebp-0x8], ecx */
            ii(0x1012_b89e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_b8a1, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x1012_b8a5, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1012_b8a8, 3); sub(ax, memw_a32[ds, edx]);             /* sub ax, [edx] */
            ii(0x1012_b8ab, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1012_b8ae, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_b8b1, 4); mov(ax, memw_a32[ds, eax + 0xc]);       /* mov ax, [eax+0xc] */
            ii(0x1012_b8b5, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1012_b8b8, 4); sub(ax, memw_a32[ds, edx + 0x4]);       /* sub ax, [edx+0x4] */
            ii(0x1012_b8bc, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1012_b8bf, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1012_b8c3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_b8c5, 2); if(jnzd(0x1012_b8d5, 0xe)) goto l_0x1012_b8d5; /* jnz 0x1012b8d5 */
            ii(0x1012_b8c7, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1012_b8cb, 5); calld(Definitions.my_get_res_data_by_id, 0x8708); /* call 0x10133fd8 */
            ii(0x1012_b8d0, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1012_b8d3, 2); jmpd(0x1012_b8e1, 0xc); goto l_0x1012_b8e1; /* jmp 0x1012b8e1 */
        l_0x1012_b8d5:
            ii(0x1012_b8d5, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1012_b8d9, 5); calld(Definitions.my_get_res_data_by_id, 0x86fa); /* call 0x10133fd8 */
            ii(0x1012_b8de, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
        l_0x1012_b8e1:
            ii(0x1012_b8e1, 4); cmp(memd_a32[ss, ebp - 0x34], 0);       /* cmp dword [ebp-0x34], 0x0 */
            ii(0x1012_b8e5, 6); if(jzd(0x1012_bada, 0x1ef)) goto l_0x1012_bada; /* jz 0x1012bada */
            ii(0x1012_b8eb, 4); movsx(eax, memw_a32[ss, ebp + 0x10]);   /* movsx eax, word [ebp+0x10] */
            ii(0x1012_b8ef, 3); cmp(eax, 0x6);                          /* cmp eax, 0x6 */
            ii(0x1012_b8f2, 2); if(jged(0x1012_b8fd, 0x9)) goto l_0x1012_b8fd; /* jge 0x1012b8fd */
            ii(0x1012_b8f4, 7); mov(memd_a32[ss, ebp - 0x38], 0);       /* mov dword [ebp-0x38], 0x0 */
            ii(0x1012_b8fb, 2); jmpd(0x1012_b91c, 0x1f); goto l_0x1012_b91c; /* jmp 0x1012b91c */
        l_0x1012_b8fd:
            ii(0x1012_b8fd, 3); mov(edx, memd_a32[ss, ebp - 0x34]);     /* mov edx, [ebp-0x34] */
            ii(0x1012_b900, 2); mov(eax, memd_a32[ds, edx]);            /* mov eax, [edx] */
            ii(0x1012_b902, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_b905, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1012_b909, 1); dec(edx);                               /* dec edx */
            ii(0x1012_b90a, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1012_b90c, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_b90e, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1012_b911, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1012_b914, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x1012_b916, 3); sar(eax, 0x2);                          /* sar eax, 0x2 */
            ii(0x1012_b919, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
        l_0x1012_b91c:
            ii(0x1012_b91c, 4); movsx(ebx, memw_a32[ss, ebp - 0x1c]);   /* movsx ebx, word [ebp-0x1c] */
            ii(0x1012_b920, 4); movsx(eax, memw_a32[ss, ebp - 0x38]);   /* movsx eax, word [ebp-0x38] */
            ii(0x1012_b924, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1012_b927, 1); dec(ebx);                               /* dec ebx */
            ii(0x1012_b928, 2); sub(ebx, eax);                          /* sub ebx, eax */
            ii(0x1012_b92a, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1012_b92d, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1012_b92f, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1012_b932, 2); sub(ebx, edx);                          /* sub ebx, edx */
            ii(0x1012_b934, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1012_b936, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_b938, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1012_b93b, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1012_b93d, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1012_b93f, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1012_b942, 3); mov(edx, memd_a32[ds, edx + 0xe]);      /* mov edx, [edx+0xe] */
            ii(0x1012_b945, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1012_b948, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1012_b94b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_b94e, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1012_b951, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_b953, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1012_b956, 4); movsx(edx, memw_a32[ss, ebp + 0x10]);   /* movsx edx, word [ebp+0x10] */
            ii(0x1012_b95a, 3); add(edx, 0x4);                          /* add edx, 0x4 */
            ii(0x1012_b95d, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x1012_b962, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_b964, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1012_b967, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1012_b969, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x1012_b96c, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x1012_b96f, 1); dec(eax);                               /* dec eax */
            ii(0x1012_b970, 3); imul(eax, eax, 0x5);                    /* imul eax, eax, 0x5 */
            ii(0x1012_b973, 3); mov(edx, memd_a32[ss, ebp + 0x10]);     /* mov edx, [ebp+0x10] */
            ii(0x1012_b976, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1012_b978, 3); mov(memd_a32[ss, ebp - 0x44], edx);     /* mov [ebp-0x44], edx */
            ii(0x1012_b97b, 3); mov(edx, memd_a32[ss, ebp - 0x34]);     /* mov edx, [ebp-0x34] */
            ii(0x1012_b97e, 3); mov(ax, memw_a32[ds, edx]);             /* mov ax, [edx] */
            ii(0x1012_b981, 4); imul(eax, memd_a32[ss, ebp - 0x40]);    /* imul eax, [ebp-0x40] */
            ii(0x1012_b985, 3); sub(memd_a32[ss, ebp - 0x20], eax);     /* sub [ebp-0x20], eax */
            ii(0x1012_b988, 3); mov(edx, memd_a32[ss, ebp - 0x40]);     /* mov edx, [ebp-0x40] */
            ii(0x1012_b98b, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1012_b98e, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1012_b993, 3); sub(eax, memd_a32[ss, ebp - 0x44]);     /* sub eax, [ebp-0x44] */
            ii(0x1012_b996, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1012_b998, 3); mov(memd_a32[ss, ebp - 0x14], edx);     /* mov [ebp-0x14], edx */
            ii(0x1012_b99b, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1012_b99f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_b9a1, 2); if(jnzd(0x1012_b9b5, 0x12)) goto l_0x1012_b9b5; /* jnz 0x1012b9b5 */
            ii(0x1012_b9a3, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1012_b9a6, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1012_b9a9, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1012_b9ac, 7); mov(memd_a32[ss, ebp - 0x30], 0);       /* mov dword [ebp-0x30], 0x0 */
            ii(0x1012_b9b3, 2); jmpd(0x1012_ba18, 0x63); goto l_0x1012_ba18; /* jmp 0x1012ba18 */
        l_0x1012_b9b5:
            ii(0x1012_b9b5, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1012_b9b8, 4); cmp(ax, memw_a32[ss, ebp - 0x14]);      /* cmp ax, [ebp-0x14] */
            ii(0x1012_b9bc, 2); if(jld(0x1012_b9ed, 0x2f)) goto l_0x1012_b9ed; /* jl 0x1012b9ed */
            ii(0x1012_b9be, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x1012_b9c2, 4); movsx(ebx, memw_a32[ss, ebp - 0x14]);   /* movsx ebx, word [ebp-0x14] */
            ii(0x1012_b9c6, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_b9c8, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1012_b9cb, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1012_b9cd, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1012_b9d0, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x1012_b9d3, 3); mov(edx, memd_a32[ss, ebp - 0x34]);     /* mov edx, [ebp-0x34] */
            ii(0x1012_b9d6, 3); cmp(ax, memw_a32[ds, edx]);             /* cmp ax, [edx] */
            ii(0x1012_b9d9, 2); if(jled(0x1012_b9e4, 0x9)) goto l_0x1012_b9e4; /* jle 0x1012b9e4 */
            ii(0x1012_b9db, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1012_b9de, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1012_b9e1, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
        l_0x1012_b9e4:
            ii(0x1012_b9e4, 7); mov(memd_a32[ss, ebp - 0x30], 0);       /* mov dword [ebp-0x30], 0x0 */
            ii(0x1012_b9eb, 2); jmpd(0x1012_ba18, 0x2b); goto l_0x1012_ba18; /* jmp 0x1012ba18 */
        l_0x1012_b9ed:
            ii(0x1012_b9ed, 7); mov(memd_a32[ss, ebp - 0x48], 0x1);     /* mov dword [ebp-0x48], 0x1 */
            ii(0x1012_b9f4, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1012_b9f8, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x1012_b9fc, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1012_b9fe, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_ba00, 4); movsx(eax, memw_a32[ss, ebp - 0x40]);   /* movsx eax, word [ebp-0x40] */
            ii(0x1012_ba04, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_ba06, 4); movsx(ebx, memw_a32[ss, ebp - 0x40]);   /* movsx ebx, word [ebp-0x40] */
            ii(0x1012_ba0a, 1); dec(ebx);                               /* dec ebx */
            ii(0x1012_ba0b, 3); lea(edx, eax - 0x2);                    /* lea edx, [eax-0x2] */
            ii(0x1012_ba0e, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_ba10, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1012_ba13, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1012_ba15, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
        l_0x1012_ba18:
            ii(0x1012_ba18, 3); mov(edx, memd_a32[ss, ebp - 0x48]);     /* mov edx, [ebp-0x48] */
            ii(0x1012_ba1b, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1012_ba1e, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1012_ba21, 3); add(dx, memw_a32[ds, eax]);             /* add dx, [eax] */
            ii(0x1012_ba24, 3); sub(edx, memd_a32[ss, ebp - 0x30]);     /* sub edx, [ebp-0x30] */
            ii(0x1012_ba27, 3); mov(memd_a32[ss, ebp - 0x4c], edx);     /* mov [ebp-0x4c], edx */
            ii(0x1012_ba2a, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
            ii(0x1012_ba31, 7); mov(memd_a32[ss, ebp - 0x2c], 0);       /* mov dword [ebp-0x2c], 0x0 */
            ii(0x1012_ba38, 2); jmpd(0x1012_ba40, 0x6); goto l_0x1012_ba40; /* jmp 0x1012ba40 */
        l_0x1012_ba3a:
            ii(0x1012_ba3a, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1012_ba3d, 3); inc(memd_a32[ss, ebp - 0x2c]);          /* inc dword [ebp-0x2c] */
        l_0x1012_ba40:
            ii(0x1012_ba40, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1012_ba43, 4); cmp(ax, memw_a32[ss, ebp + 0x10]);      /* cmp ax, [ebp+0x10] */
            ii(0x1012_ba47, 6); if(jged(0x1012_bada, 0x8d)) goto l_0x1012_bada; /* jge 0x1012bada */
            ii(0x1012_ba4d, 4); movsx(edx, memw_a32[ss, ebp - 0x2c]);   /* movsx edx, word [ebp-0x2c] */
            ii(0x1012_ba51, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x1012_ba56, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_ba58, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1012_ba5b, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1012_ba5d, 3); mov(memd_a32[ss, ebp - 0x18], edx);     /* mov [ebp-0x18], edx */
            ii(0x1012_ba60, 4); movsx(edx, memw_a32[ss, ebp - 0x2c]);   /* movsx edx, word [ebp-0x2c] */
            ii(0x1012_ba64, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x1012_ba69, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_ba6b, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1012_ba6e, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1012_ba70, 4); movsx(edx, memw_a32[ss, ebp - 0x4c]);   /* movsx edx, word [ebp-0x4c] */
            ii(0x1012_ba74, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1012_ba77, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1012_ba7b, 4); movsx(ebx, memw_a32[ss, ebp - 0x48]);   /* movsx ebx, word [ebp-0x48] */
            ii(0x1012_ba7f, 3); imul(eax, ebx);                         /* imul eax, ebx */
            ii(0x1012_ba82, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_ba84, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1012_ba87, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1012_ba8a, 4); imul(eax, memd_a32[ss, ebp - 0x38]);    /* imul eax, [ebp-0x38] */
            ii(0x1012_ba8e, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1012_ba91, 3); mov(ebx, memd_a32[ss, ebp - 0x34]);     /* mov ebx, [ebp-0x34] */
            ii(0x1012_ba94, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_ba97, 3); mov(edx, memd_a32[ds, eax + 0xe]);      /* mov edx, [eax+0xe] */
            ii(0x1012_ba9a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1012_ba9d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_baa0, 3); mov(eax, memd_a32[ds, eax + 0xe]);      /* mov eax, [eax+0xe] */
            ii(0x1012_baa3, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_baa6, 4); movsx(ecx, memw_a32[ss, ebp - 0x24]);   /* movsx ecx, word [ebp-0x24] */
            ii(0x1012_baaa, 3); imul(ecx, eax);                         /* imul ecx, eax */
            ii(0x1012_baad, 4); movsx(eax, memw_a32[ss, ebp - 0x28]);   /* movsx eax, word [ebp-0x28] */
            ii(0x1012_bab1, 3); add(eax, memd_a32[ss, ebp - 0x3c]);     /* add eax, [ebp-0x3c] */
            ii(0x1012_bab4, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1012_bab6, 5); calld(0x1013_f410, 0x1_3955);           /* call 0x1013f410 */
            ii(0x1012_babb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_babe, 3); dec(memd_a32[ss, ebp - 0x8]);           /* dec dword [ebp-0x8] */
            ii(0x1012_bac1, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1012_bac5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_bac7, 2); if(jnzd(0x1012_bad5, 0xc)) goto l_0x1012_bad5; /* jnz 0x1012bad5 */
            ii(0x1012_bac9, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1012_bacd, 5); calld(Definitions.my_get_res_data_by_id, 0x8506); /* call 0x10133fd8 */
            ii(0x1012_bad2, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
        l_0x1012_bad5:
            ii(0x1012_bad5, 5); jmpd(0x1012_ba3a, -0xa0); goto l_0x1012_ba3a; /* jmp 0x1012ba3a */
        l_0x1012_bada:
            ii(0x1012_bada, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_badc, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_badd, 1); popd(edi);                              /* pop edi */
            ii(0x1012_bade, 1); popd(esi);                              /* pop esi */
            ii(0x1012_badf, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}
