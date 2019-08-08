using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cf20c25b-ac31-463f-9791-796e34689618")]
        public void Method_100e_8b24()
        {
            ii(0x100e_8b24, 5); pushd(0x44);                            /* push 0x44 */
            ii(0x100e_8b29, 5); calld(Definitions.sys_check_available_stack_size, 0x7_d224); /* call 0x10165d52 */
            ii(0x100e_8b2e, 1); pushd(esi);                             /* push esi */
            ii(0x100e_8b2f, 1); pushd(edi);                             /* push edi */
            ii(0x100e_8b30, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_8b31, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_8b33, 6); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x100e_8b39, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_8b3c, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100e_8b3f, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100e_8b42, 3); mov(memd_a32[ss, ebp - 0x8], ecx);      /* mov [ebp-0x8], ecx */
            ii(0x100e_8b45, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_8b48, 4); mov(ax, memw_a32[ds, eax + 0x4]);       /* mov ax, [eax+0x4] */
            ii(0x100e_8b4c, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100e_8b4f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_8b52, 4); mov(ax, memw_a32[ds, eax + 0x6]);       /* mov ax, [eax+0x6] */
            ii(0x100e_8b56, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100e_8b59, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100e_8b5d, 4); movsx(eax, memw_a32[ss, ebp + 0x10]);   /* movsx eax, word [ebp+0x10] */
            ii(0x100e_8b61, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100e_8b64, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_8b68, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_8b6a, 3); mov(memd_a32[ss, ebp - 0x1c], edx);     /* mov [ebp-0x1c], edx */
            ii(0x100e_8b6d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_8b70, 5); add(eax, 0x308);                        /* add eax, 0x308 */
            ii(0x100e_8b75, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100e_8b78, 5); calld(/* sys */ 0x1016_b258, 0x8_26db); /* call 0x1016b258 */
        l_0x100e_8b7d:
            ii(0x100e_8b7d, 3); dec(memd_a32[ss, ebp - 0x18]);          /* dec dword [ebp-0x18] */
            ii(0x100e_8b80, 5); cmp(memw_a32[ss, ebp - 0x18], -0x1 /* 0xff */); /* cmp word [ebp-0x18], 0xffff */
            ii(0x100e_8b85, 6); if(jzd(0x100e_8c49, 0xbe)) goto l_0x100e_8c49; /* jz 0x100e8c49 */
            ii(0x100e_8b8b, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100e_8b8e, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100e_8b91, 7); mov(memd_a32[ss, ebp - 0x24], 0);       /* mov dword [ebp-0x24], 0x0 */
        l_0x100e_8b98:
            ii(0x100e_8b98, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100e_8b9b, 4); cmp(ax, memw_a32[ss, ebp - 0x14]);      /* cmp ax, [ebp-0x14] */
            ii(0x100e_8b9f, 6); if(jged(0x100e_8c30, 0x8b)) goto l_0x100e_8c30; /* jge 0x100e8c30 */
            ii(0x100e_8ba5, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100e_8ba8, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100e_8bab, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100e_8bae, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100e_8bb1, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x100e_8bb4, 4); add(memd_a32[ss, ebp - 0x20], 0x2);     /* add dword [ebp-0x20], 0x2 */
            ii(0x100e_8bb8, 4); movsx(eax, memw_a32[ss, ebp - 0x2c]);   /* movsx eax, word [ebp-0x2c] */
            ii(0x100e_8bbc, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_8bbe, 2); if(jged(0x100e_8bfd, 0x3d)) goto l_0x100e_8bfd; /* jge 0x100e8bfd */
            ii(0x100e_8bc0, 4); movsx(eax, memw_a32[ss, ebp - 0x2c]);   /* movsx eax, word [ebp-0x2c] */
            ii(0x100e_8bc4, 5); calld(/* sys */ 0x1016_5df8, 0x7_d22f); /* call 0x10165df8 */
            ii(0x100e_8bc9, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x100e_8bcc, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100e_8bcf, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x100e_8bd1, 3); mov(memb_a32[ss, ebp - 0x34], al);      /* mov [ebp-0x34], al */
            ii(0x100e_8bd4, 4); movsx(ebx, memw_a32[ss, ebp - 0x2c]);   /* movsx ebx, word [ebp-0x2c] */
            ii(0x100e_8bd8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_8bda, 3); mov(dl, memb_a32[ss, ebp - 0x34]);      /* mov dl, [ebp-0x34] */
            ii(0x100e_8bdd, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_8be0, 3); add(eax, memd_a32[ss, ebp - 0x28]);     /* add eax, [ebp-0x28] */
            ii(0x100e_8be3, 5); calld(Definitions.sys_memset, 0x7_d1f8); /* call 0x10165de0 */
            ii(0x100e_8be8, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100e_8beb, 3); inc(memd_a32[ss, ebp - 0x20]);          /* inc dword [ebp-0x20] */
            ii(0x100e_8bee, 4); movsx(eax, memw_a32[ss, ebp - 0x2c]);   /* movsx eax, word [ebp-0x2c] */
            ii(0x100e_8bf2, 3); add(memd_a32[ss, ebp - 0x28], eax);     /* add [ebp-0x28], eax */
            ii(0x100e_8bf5, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100e_8bf8, 3); add(memd_a32[ss, ebp - 0x24], eax);     /* add [ebp-0x24], eax */
            ii(0x100e_8bfb, 2); jmpd(0x100e_8c2b, 0x2e); goto l_0x100e_8c2b; /* jmp 0x100e8c2b */
        l_0x100e_8bfd:
            ii(0x100e_8bfd, 4); movsx(eax, memw_a32[ss, ebp - 0x2c]);   /* movsx eax, word [ebp-0x2c] */
            ii(0x100e_8c01, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_8c03, 2); if(jled(0x100e_8c2b, 0x26)) goto l_0x100e_8c2b; /* jle 0x100e8c2b */
            ii(0x100e_8c05, 4); movsx(ebx, memw_a32[ss, ebp - 0x2c]);   /* movsx ebx, word [ebp-0x2c] */
            ii(0x100e_8c09, 3); mov(edx, memd_a32[ss, ebp - 0x20]);     /* mov edx, [ebp-0x20] */
            ii(0x100e_8c0c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_8c0f, 3); add(eax, memd_a32[ss, ebp - 0x28]);     /* add eax, [ebp-0x28] */
            ii(0x100e_8c12, 5); calld(Definitions.sys_memcpy, 0x7_d234); /* call 0x10165e4b */
            ii(0x100e_8c17, 4); movsx(eax, memw_a32[ss, ebp - 0x2c]);   /* movsx eax, word [ebp-0x2c] */
            ii(0x100e_8c1b, 3); add(memd_a32[ss, ebp - 0x20], eax);     /* add [ebp-0x20], eax */
            ii(0x100e_8c1e, 4); movsx(eax, memw_a32[ss, ebp - 0x2c]);   /* movsx eax, word [ebp-0x2c] */
            ii(0x100e_8c22, 3); add(memd_a32[ss, ebp - 0x28], eax);     /* add [ebp-0x28], eax */
            ii(0x100e_8c25, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100e_8c28, 3); add(memd_a32[ss, ebp - 0x24], eax);     /* add [ebp-0x24], eax */
        l_0x100e_8c2b:
            ii(0x100e_8c2b, 5); jmpd(0x100e_8b98, -0x98); goto l_0x100e_8b98; /* jmp 0x100e8b98 */
        l_0x100e_8c30:
            ii(0x100e_8c30, 4); movsx(eax, memw_a32[ss, ebp + 0x10]);   /* movsx eax, word [ebp+0x10] */
            ii(0x100e_8c34, 3); add(memd_a32[ss, ebp - 0x1c], eax);     /* add [ebp-0x1c], eax */
            ii(0x100e_8c37, 6); test(memw_a32[ss, ebp - 0x18], 0x1f);   /* test word [ebp-0x18], 0x1f */
            ii(0x100e_8c3d, 2); if(jnzd(0x100e_8c44, 0x5)) goto l_0x100e_8c44; /* jnz 0x100e8c44 */
            ii(0x100e_8c3f, 5); calld(/* sys */ 0x1016_b258, 0x8_2614); /* call 0x1016b258 */
        l_0x100e_8c44:
            ii(0x100e_8c44, 5); jmpd(0x100e_8b7d, -0xcc); goto l_0x100e_8b7d; /* jmp 0x100e8b7d */
        l_0x100e_8c49:
            ii(0x100e_8c49, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_8c4b, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_8c4c, 1); popd(edi);                              /* pop edi */
            ii(0x100e_8c4d, 1); popd(esi);                              /* pop esi */
            ii(0x100e_8c4e, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}
