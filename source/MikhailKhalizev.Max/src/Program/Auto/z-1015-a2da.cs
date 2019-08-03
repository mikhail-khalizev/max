using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("213de83b-63db-4f71-af0f-b37b7d0fcbff")]
        public void Method_1015_a2da()
        {
            ii(0x1015_a2da, 5); pushd(0x4c);                            /* push 0x4c */
            ii(0x1015_a2df, 5); calld(Definitions.sys_check_available_stack_size, 0xba6e); /* call 0x10165d52 */
            ii(0x1015_a2e4, 1); pushd(esi);                             /* push esi */
            ii(0x1015_a2e5, 1); pushd(edi);                             /* push edi */
            ii(0x1015_a2e6, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_a2e7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_a2e9, 6); sub(esp, 0x38);                         /* sub esp, 0x38 */
            ii(0x1015_a2ef, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1015_a2f2, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1015_a2f5, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1015_a2f8, 3); mov(memd_a32[ss, ebp - 0xc], ecx);      /* mov [ebp-0xc], ecx */
            ii(0x1015_a2fb, 7); mov(memd_a32[ss, ebp - 0x14], 0xffff);  /* mov dword [ebp-0x14], 0xffff */
            ii(0x1015_a302, 4); cmp(memb_a32[ss, ebp + 0x1c], 0);       /* cmp byte [ebp+0x1c], 0x0 */
            ii(0x1015_a306, 2); if(jnzd(0x1015_a362, 0x5a)) goto l_0x1015_a362; /* jnz 0x1015a362 */
            ii(0x1015_a308, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1015_a30c, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1015_a312, 7); inc(memw_a32[ds, eax + 0x101c_a554]);   /* inc word [eax+0x101ca554] */
            ii(0x1015_a319, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1015_a31d, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1015_a323, 6); mov(eax, memd_a32[ds, eax + 0x101c_a552]); /* mov eax, [eax+0x101ca552] */
            ii(0x1015_a329, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_a32c, 5); cmp(eax, 0x1fff);                       /* cmp eax, 0x1fff */
            ii(0x1015_a331, 2); if(jld(0x1015_a346, 0x13)) goto l_0x1015_a346; /* jl 0x1015a346 */
            ii(0x1015_a333, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1015_a337, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1015_a33d, 9); mov(memw_a32[ds, eax + 0x101c_a554], 0x1); /* mov word [eax+0x101ca554], 0x1 */
        l_0x1015_a346:
            ii(0x1015_a346, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1015_a34a, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1015_a350, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_a353, 3); shl(edx, 0xd);                          /* shl edx, 0xd */
            ii(0x1015_a356, 7); mov(ax, memw_a32[ds, eax + 0x101c_a554]); /* mov ax, [eax+0x101ca554] */
            ii(0x1015_a35d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1015_a35f, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
        l_0x1015_a362:
            ii(0x1015_a362, 5); mov(eax, 0xe1);                         /* mov eax, 0xe1 */
            ii(0x1015_a367, 5); calld(Definitions.sys_new, 0xba94);     /* call 0x10165e00 */
            ii(0x1015_a36c, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1015_a36f, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_a372, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1015_a375, 4); cmp(memd_a32[ss, ebp - 0x1c], 0);       /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1015_a379, 2); if(jzd(0x1015_a3a1, 0x26)) goto l_0x1015_a3a1; /* jz 0x1015a3a1 */
            ii(0x1015_a37b, 4); movsx(eax, memw_a32[ss, ebp + 0x18]);   /* movsx eax, word [ebp+0x18] */
            ii(0x1015_a37f, 1); pushd(eax);                             /* push eax */
            ii(0x1015_a380, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_a382, 4); mov(cx, memw_a32[ss, ebp - 0x14]);      /* mov cx, [ebp-0x14] */
            ii(0x1015_a386, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1015_a38a, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1015_a38e, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1015_a391, 5); calld(0x1014_9237, -0x1115f);           /* call 0x10149237 */
            ii(0x1015_a396, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1015_a399, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1015_a39c, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1015_a39f, 2); jmpd(0x1015_a3a7, 0x6); goto l_0x1015_a3a7; /* jmp 0x1015a3a7 */
        l_0x1015_a3a1:
            ii(0x1015_a3a1, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1015_a3a4, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
        l_0x1015_a3a7:
            ii(0x1015_a3a7, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1015_a3aa, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1015_a3ad, 4); cmp(memb_a32[ss, ebp + 0x1c], 0);       /* cmp byte [ebp+0x1c], 0x0 */
            ii(0x1015_a3b1, 2); if(jnzd(0x1015_a409, 0x56)) goto l_0x1015_a409; /* jnz 0x1015a409 */
            ii(0x1015_a3b3, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1015_a3b8, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1015_a3bb, 5); calld(0x1007_623c, -0xe4184);           /* call 0x1007623c */
            ii(0x1015_a3c0, 5); calld(0x100c_b7b4, -0x8ec11);           /* call 0x100cb7b4 */
            ii(0x1015_a3c5, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1015_a3c9, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1015_a3cf, 5); mov(edx, 0x101c_a468);                  /* mov edx, 0x101ca468 */
            ii(0x1015_a3d4, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1015_a3d6, 3); mov(memd_a32[ss, ebp - 0x2c], edx);     /* mov [ebp-0x2c], edx */
            ii(0x1015_a3d9, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1015_a3dd, 3); add(eax, memd_a32[ss, ebp - 0x2c]);     /* add eax, [ebp-0x2c] */
            ii(0x1015_a3e0, 3); mov(dl, memb_a32[ds, eax + 0x2a]);      /* mov dl, [eax+0x2a] */
            ii(0x1015_a3e3, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1015_a3e6, 3); mov(memb_a32[ds, eax + 0x27], dl);      /* mov [eax+0x27], dl */
            ii(0x1015_a3e9, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1015_a3ed, 3); add(eax, memd_a32[ss, ebp - 0x2c]);     /* add eax, [ebp-0x2c] */
            ii(0x1015_a3f0, 3); inc(memb_a32[ds, eax + 0x2a]);          /* inc byte [eax+0x2a] */
            ii(0x1015_a3f3, 3); mov(al, memb_a32[ds, eax + 0x2a]);      /* mov al, [eax+0x2a] */
            ii(0x1015_a3f6, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_a3fb, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_a3fd, 2); if(jnzd(0x1015_a409, 0xa)) goto l_0x1015_a409; /* jnz 0x1015a409 */
            ii(0x1015_a3ff, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1015_a403, 3); add(eax, memd_a32[ss, ebp - 0x2c]);     /* add eax, [ebp-0x2c] */
            ii(0x1015_a406, 3); inc(memb_a32[ds, eax + 0x2a]);          /* inc byte [eax+0x2a] */
        l_0x1015_a409:
            ii(0x1015_a409, 7); cmp(memb_a32[ds, 0x101c_391e], 0xc);    /* cmp byte [0x101c391e], 0xc */
            ii(0x1015_a410, 2); if(jzd(0x1015_a41b, 0x9)) goto l_0x1015_a41b; /* jz 0x1015a41b */
            ii(0x1015_a412, 7); cmp(memb_a32[ds, 0x101c_37d4], 0);      /* cmp byte [0x101c37d4], 0x0 */
            ii(0x1015_a419, 2); if(jzd(0x1015_a41d, 0x2)) goto l_0x1015_a41d; /* jz 0x1015a41d */
        l_0x1015_a41b:
            ii(0x1015_a41b, 2); jmpd(0x1015_a423, 0x6); goto l_0x1015_a423; /* jmp 0x1015a423 */
        l_0x1015_a41d:
            ii(0x1015_a41d, 4); cmp(memb_a32[ss, ebp + 0x1c], 0);       /* cmp byte [ebp+0x1c], 0x0 */
            ii(0x1015_a421, 2); if(jzd(0x1015_a425, 0x2)) goto l_0x1015_a425; /* jz 0x1015a425 */
        l_0x1015_a423:
            ii(0x1015_a423, 2); jmpd(0x1015_a42e, 0x9); goto l_0x1015_a42e; /* jmp 0x1015a42e */
        l_0x1015_a425:
            ii(0x1015_a425, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1015_a428, 6); mov(memw_a32[ds, eax + 0x52], 0);       /* mov word [eax+0x52], 0x0 */
        l_0x1015_a42e:
            ii(0x1015_a42e, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1015_a431, 5); cmp(memw_a32[ds, eax + 0x8], 0x42);     /* cmp word [eax+0x8], 0x42 */
            ii(0x1015_a436, 2); if(jnzd(0x1015_a44b, 0x13)) goto l_0x1015_a44b; /* jnz 0x1015a44b */
            ii(0x1015_a438, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1015_a43b, 5); calld(0x1007_623c, -0xe4204);           /* call 0x1007623c */
            ii(0x1015_a440, 4); mov(dx, memw_a32[ds, eax + 0x1f]);      /* mov dx, [eax+0x1f] */
            ii(0x1015_a444, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1015_a447, 4); mov(memw_a32[ds, eax + 0x52], dx);      /* mov [eax+0x52], dx */
        l_0x1015_a44b:
            ii(0x1015_a44b, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1015_a44e, 4); test(memb_a32[ds, eax + 0x12], 0x4);    /* test byte [eax+0x12], 0x4 */
            ii(0x1015_a452, 2); if(jzd(0x1015_a462, 0xe)) goto l_0x1015_a462; /* jz 0x1015a462 */
            ii(0x1015_a454, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1015_a457, 4); mov(memb_a32[ds, eax + 0x3d], 0x9);     /* mov byte [eax+0x3d], 0x9 */
            ii(0x1015_a45b, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1015_a45e, 4); mov(memb_a32[ds, eax + 0x3e], 0xe);     /* mov byte [eax+0x3e], 0xe */
        l_0x1015_a462:
            ii(0x1015_a462, 4); cmp(memb_a32[ss, ebp + 0x1c], 0);       /* cmp byte [ebp+0x1c], 0x0 */
            ii(0x1015_a466, 6); if(jnzd(0x1015_a59e, 0x132)) goto l_0x1015_a59e; /* jnz 0x1015a59e */
            ii(0x1015_a46c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_a46f, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1015_a472, 2); jmpd(0x1015_a4ce, 0x5a); goto l_0x1015_a4ce; /* jmp 0x1015a4ce */
        l_0x1015_a474:
            ii(0x1015_a474, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1015_a477, 4); mov(memb_a32[ds, eax + 0x3d], 0xc);     /* mov byte [eax+0x3d], 0xc */
            ii(0x1015_a47b, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1015_a47e, 4); mov(memb_a32[ds, eax + 0x3e], 0x1);     /* mov byte [eax+0x3e], 0x1 */
            ii(0x1015_a482, 5); jmpd(0x1015_a59e, 0x117); goto l_0x1015_a59e; /* jmp 0x1015a59e */
        l_0x1015_a487:
            ii(0x1015_a487, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1015_a48a, 4); mov(memb_a32[ds, eax + 0x3d], 0x7);     /* mov byte [eax+0x3d], 0x7 */
            ii(0x1015_a48e, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1015_a491, 4); mov(memb_a32[ds, eax + 0x3e], 0);       /* mov byte [eax+0x3e], 0x0 */
            ii(0x1015_a495, 5); jmpd(0x1015_a59e, 0x104); goto l_0x1015_a59e; /* jmp 0x1015a59e */
        l_0x1015_a49a:
            ii(0x1015_a49a, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1015_a49d, 4); mov(memb_a32[ds, eax + 0x3d], 0x8);     /* mov byte [eax+0x3d], 0x8 */
            ii(0x1015_a4a1, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1015_a4a4, 4); mov(memb_a32[ds, eax + 0x3e], 0x1);     /* mov byte [eax+0x3e], 0x1 */
            ii(0x1015_a4a8, 5); jmpd(0x1015_a59e, 0xf1); goto l_0x1015_a59e; /* jmp 0x1015a59e */
        l_0x1015_a4ad:
            ii(0x1015_a4ad, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1015_a4b0, 6); mov(memw_a32[ds, eax + 0x52], 0);       /* mov word [eax+0x52], 0x0 */
            ii(0x1015_a4b6, 5); jmpd(0x1015_a59e, 0xe3); goto l_0x1015_a59e; /* jmp 0x1015a59e */
        l_0x1015_a4bb:
            ii(0x1015_a4bb, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1015_a4be, 6); mov(memw_a32[ds, eax + 0x52], 0);       /* mov word [eax+0x52], 0x0 */
            ii(0x1015_a4c4, 5); jmpd(0x1015_a59e, 0xd5); goto l_0x1015_a59e; /* jmp 0x1015a59e */
        l_0x1015_a4c9:
            ii(0x1015_a4c9, 5); jmpd(0x1015_a59e, 0xd0); goto l_0x1015_a59e; /* jmp 0x1015a59e */
        l_0x1015_a4ce:
            ii(0x1015_a4ce, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1015_a4d1, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1015_a4d4, 5); cmp(memw_a32[ss, ebp - 0x34], 0x1c);    /* cmp word [ebp-0x34], 0x1c */
            ii(0x1015_a4d9, 6); if(jbd(0x1015_a540, 0x61)) goto l_0x1015_a540; /* jb 0x1015a540 */
            ii(0x1015_a4df, 5); cmp(memw_a32[ss, ebp - 0x34], 0x1c);    /* cmp word [ebp-0x34], 0x1c */
            ii(0x1015_a4e4, 2); if(jbed(0x1015_a487, -0x5f)) goto l_0x1015_a487; /* jbe 0x1015a487 */
            ii(0x1015_a4e6, 5); cmp(memw_a32[ss, ebp - 0x34], 0x29);    /* cmp word [ebp-0x34], 0x29 */
            ii(0x1015_a4eb, 2); if(jbd(0x1015_a514, 0x27)) goto l_0x1015_a514; /* jb 0x1015a514 */
            ii(0x1015_a4ed, 5); cmp(memw_a32[ss, ebp - 0x34], 0x2a);    /* cmp word [ebp-0x34], 0x2a */
            ii(0x1015_a4f2, 2); if(jbed(0x1015_a474, -0x80)) goto l_0x1015_a474; /* jbe 0x1015a474 */
            ii(0x1015_a4f4, 5); cmp(memw_a32[ss, ebp - 0x34], 0x48);    /* cmp word [ebp-0x34], 0x48 */
            ii(0x1015_a4f9, 2); if(jbd(0x1015_a50b, 0x10)) goto l_0x1015_a50b; /* jb 0x1015a50b */
            ii(0x1015_a4fb, 5); cmp(memw_a32[ss, ebp - 0x34], 0x48);    /* cmp word [ebp-0x34], 0x48 */
            ii(0x1015_a500, 2); if(jbed(0x1015_a4ad, -0x55)) goto l_0x1015_a4ad; /* jbe 0x1015a4ad */
            ii(0x1015_a502, 5); cmp(memw_a32[ss, ebp - 0x34], 0x4e);    /* cmp word [ebp-0x34], 0x4e */
            ii(0x1015_a507, 2); if(jzd(0x1015_a4ad, -0x5c)) goto l_0x1015_a4ad; /* jz 0x1015a4ad */
            ii(0x1015_a509, 2); jmpd(0x1015_a4c9, -0x42); goto l_0x1015_a4c9; /* jmp 0x1015a4c9 */
        l_0x1015_a50b:
            ii(0x1015_a50b, 5); cmp(memw_a32[ss, ebp - 0x34], 0x41);    /* cmp word [ebp-0x34], 0x41 */
            ii(0x1015_a510, 2); if(jzd(0x1015_a4ad, -0x65)) goto l_0x1015_a4ad; /* jz 0x1015a4ad */
            ii(0x1015_a512, 2); jmpd(0x1015_a4c9, -0x4b); goto l_0x1015_a4c9; /* jmp 0x1015a4c9 */
        l_0x1015_a514:
            ii(0x1015_a514, 5); cmp(memw_a32[ss, ebp - 0x34], 0x22);    /* cmp word [ebp-0x34], 0x22 */
            ii(0x1015_a519, 2); if(jbd(0x1015_a533, 0x18)) goto l_0x1015_a533; /* jb 0x1015a533 */
            ii(0x1015_a51b, 5); cmp(memw_a32[ss, ebp - 0x34], 0x25);    /* cmp word [ebp-0x34], 0x25 */
            ii(0x1015_a520, 6); if(jbed(0x1015_a474, -0xb2)) goto l_0x1015_a474; /* jbe 0x1015a474 */
            ii(0x1015_a526, 5); cmp(memw_a32[ss, ebp - 0x34], 0x28);    /* cmp word [ebp-0x34], 0x28 */
            ii(0x1015_a52b, 6); if(jzd(0x1015_a487, -0xaa)) goto l_0x1015_a487; /* jz 0x1015a487 */
            ii(0x1015_a531, 2); jmpd(0x1015_a4c9, -0x6a); goto l_0x1015_a4c9; /* jmp 0x1015a4c9 */
        l_0x1015_a533:
            ii(0x1015_a533, 5); cmp(memw_a32[ss, ebp - 0x34], 0x1d);    /* cmp word [ebp-0x34], 0x1d */
            ii(0x1015_a538, 6); if(jzd(0x1015_a49a, -0xa4)) goto l_0x1015_a49a; /* jz 0x1015a49a */
            ii(0x1015_a53e, 2); jmpd(0x1015_a4c9, -0x77); goto l_0x1015_a4c9; /* jmp 0x1015a4c9 */
        l_0x1015_a540:
            ii(0x1015_a540, 5); cmp(memw_a32[ss, ebp - 0x34], 0x3);     /* cmp word [ebp-0x34], 0x3 */
            ii(0x1015_a545, 2); if(jbd(0x1015_a589, 0x42)) goto l_0x1015_a589; /* jb 0x1015a589 */
            ii(0x1015_a547, 5); cmp(memw_a32[ss, ebp - 0x34], 0x3);     /* cmp word [ebp-0x34], 0x3 */
            ii(0x1015_a54c, 6); if(jbed(0x1015_a4bb, -0x97)) goto l_0x1015_a4bb; /* jbe 0x1015a4bb */
            ii(0x1015_a552, 5); cmp(memw_a32[ss, ebp - 0x34], 0x9);     /* cmp word [ebp-0x34], 0x9 */
            ii(0x1015_a557, 2); if(jbd(0x1015_a579, 0x20)) goto l_0x1015_a579; /* jb 0x1015a579 */
            ii(0x1015_a559, 5); cmp(memw_a32[ss, ebp - 0x34], 0x9);     /* cmp word [ebp-0x34], 0x9 */
            ii(0x1015_a55e, 6); if(jbed(0x1015_a4bb, -0xa9)) goto l_0x1015_a4bb; /* jbe 0x1015a4bb */
            ii(0x1015_a564, 5); cmp(memw_a32[ss, ebp - 0x34], 0xb);     /* cmp word [ebp-0x34], 0xb */
            ii(0x1015_a569, 6); if(jbed(0x1015_a4bb, -0xb4)) goto l_0x1015_a4bb; /* jbe 0x1015a4bb */
            ii(0x1015_a56f, 5); jmpd(0x1015_a4c9, -0xab); goto l_0x1015_a4c9; /* jmp 0x1015a4c9 */
        //  ii(0x1015_a574, 5); Недостижимый код.
l_0x1015_a579:
            ii(0x1015_a579, 5); cmp(memw_a32[ss, ebp - 0x34], 0x5);     /* cmp word [ebp-0x34], 0x5 */
            ii(0x1015_a57e, 6); if(jzd(0x1015_a474, -0x110)) goto l_0x1015_a474; /* jz 0x1015a474 */
            ii(0x1015_a584, 5); jmpd(0x1015_a4c9, -0xc0); goto l_0x1015_a4c9; /* jmp 0x1015a4c9 */
        l_0x1015_a589:
            ii(0x1015_a589, 5); cmp(memw_a32[ss, ebp - 0x34], 0);       /* cmp word [ebp-0x34], 0x0 */
            ii(0x1015_a58e, 6); if(jbed(0x1015_a487, -0x10d)) goto l_0x1015_a487; /* jbe 0x1015a487 */
            ii(0x1015_a594, 5); jmpd(0x1015_a49a, -0xff); goto l_0x1015_a49a; /* jmp 0x1015a49a */
        //  ii(0x1015_a599, 5); Недостижимый код.
l_0x1015_a59e:
            ii(0x1015_a59e, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1015_a5a2, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1015_a5a5, 2); if(jnzd(0x1015_a5b0, 0x9)) goto l_0x1015_a5b0; /* jnz 0x1015a5b0 */
            ii(0x1015_a5a7, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1015_a5aa, 4); test(memb_a32[ds, eax + 0x15], 0x10);   /* test byte [eax+0x15], 0x10 */
            ii(0x1015_a5ae, 2); if(jnzd(0x1015_a5b2, 0x2)) goto l_0x1015_a5b2; /* jnz 0x1015a5b2 */
        l_0x1015_a5b0:
            ii(0x1015_a5b0, 2); jmpd(0x1015_a5b9, 0x7); goto l_0x1015_a5b9; /* jmp 0x1015a5b9 */
        l_0x1015_a5b2:
            ii(0x1015_a5b2, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1015_a5b5, 4); mov(memb_a32[ds, eax + 0x3d], 0x1a);    /* mov byte [eax+0x3d], 0x1a */
        l_0x1015_a5b9:
            ii(0x1015_a5b9, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1015_a5bd, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1015_a5c0, 5); mov(edx, 0x101c_81c0);                  /* mov edx, 0x101c81c0 */
            ii(0x1015_a5c5, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1015_a5c7, 3); mov(memd_a32[ss, ebp - 0x38], edx);     /* mov [ebp-0x38], edx */
            ii(0x1015_a5ca, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1015_a5cd, 4); test(memb_a32[ds, eax + 0x15], 0xa);    /* test byte [eax+0x15], 0xa */
            ii(0x1015_a5d1, 2); if(jzd(0x1015_a612, 0x3f)) goto l_0x1015_a612; /* jz 0x1015a612 */
            ii(0x1015_a5d3, 5); calld(0x1015_5144, -0x5494);            /* call 0x10155144 */
            ii(0x1015_a5d8, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_a5da, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1015_a5dc, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1015_a5df, 3); mov(al, memb_a32[ds, eax + 0x29]);      /* mov al, [eax+0x29] */
            ii(0x1015_a5e2, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_a5e4, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_a5e7, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1015_a5ea, 5); calld(0x1014_e788, -0xbe67);            /* call 0x1014e788 */
            ii(0x1015_a5ef, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1015_a5f2, 4); test(memb_a32[ds, eax + 0x15], 0x8);    /* test byte [eax+0x15], 0x8 */
            ii(0x1015_a5f6, 2); if(jzd(0x1015_a612, 0x1a)) goto l_0x1015_a612; /* jz 0x1015a612 */
            ii(0x1015_a5f8, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1015_a5fb, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1015_a5fe, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_a600, 3); mov(dl, memb_a32[ds, eax + 0x3]);       /* mov dl, [eax+0x3] */
            ii(0x1015_a603, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1015_a606, 4); add(dx, memw_a32[ds, eax + 0x35]);      /* add dx, [eax+0x35] */
            ii(0x1015_a60a, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1015_a60d, 1); dec(edx);                               /* dec edx */
            ii(0x1015_a60e, 4); mov(memw_a32[ds, eax + 0x3b], dx);      /* mov [eax+0x3b], dx */
        l_0x1015_a612:
            ii(0x1015_a612, 5); cmp(memw_a32[ss, ebp - 0x8], 0x28);     /* cmp word [ebp-0x8], 0x28 */
            ii(0x1015_a617, 2); if(jnzd(0x1015_a61f, 0x6)) goto l_0x1015_a61f; /* jnz 0x1015a61f */
            ii(0x1015_a619, 4); cmp(memb_a32[ss, ebp + 0x1c], 0);       /* cmp byte [ebp+0x1c], 0x0 */
            ii(0x1015_a61d, 2); if(jzd(0x1015_a621, 0x2)) goto l_0x1015_a621; /* jz 0x1015a621 */
        l_0x1015_a61f:
            ii(0x1015_a61f, 2); jmpd(0x1015_a631, 0x10); goto l_0x1015_a631; /* jmp 0x1015a631 */
        l_0x1015_a621:
            ii(0x1015_a621, 4); movsx(ebx, memw_a32[ss, ebp + 0x14]);   /* movsx ebx, word [ebp+0x14] */
            ii(0x1015_a625, 4); movsx(edx, memw_a32[ss, ebp + 0x10]);   /* movsx edx, word [ebp+0x10] */
            ii(0x1015_a629, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1015_a62c, 5); calld(0x1016_3263, 0x8c32);             /* call 0x10163263 */
        l_0x1015_a631:
            ii(0x1015_a631, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_a633, 3); mov(cl, memb_a32[ss, ebp + 0x20]);      /* mov cl, [ebp+0x20] */
            ii(0x1015_a636, 4); movsx(ebx, memw_a32[ss, ebp + 0x14]);   /* movsx ebx, word [ebp+0x14] */
            ii(0x1015_a63a, 4); movsx(edx, memw_a32[ss, ebp + 0x10]);   /* movsx edx, word [ebp+0x10] */
            ii(0x1015_a63e, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1015_a641, 5); calld(0x1014_a48e, -0x101b8);           /* call 0x1014a48e */
            ii(0x1015_a646, 4); cmp(memb_a32[ss, ebp + 0x1c], 0);       /* cmp byte [ebp+0x1c], 0x0 */
            ii(0x1015_a64a, 2); if(jnzd(0x1015_a694, 0x48)) goto l_0x1015_a694; /* jnz 0x1015a694 */
            ii(0x1015_a64c, 3); mov(edx, memd_a32[ss, ebp - 0x28]);     /* mov edx, [ebp-0x28] */
            ii(0x1015_a64f, 5); mov(eax, 0x101c_39c0);                  /* mov eax, 0x101c39c0 */
            ii(0x1015_a654, 5); calld(0x1010_3e3e, -0x5681b);           /* call 0x10103e3e */
            ii(0x1015_a659, 5); cmp(memw_a32[ss, ebp - 0x8], 0x9);      /* cmp word [ebp-0x8], 0x9 */
            ii(0x1015_a65e, 2); if(jzd(0x1015_a667, 0x7)) goto l_0x1015_a667; /* jz 0x1015a667 */
            ii(0x1015_a660, 5); cmp(memw_a32[ss, ebp - 0x8], 0xb);      /* cmp word [ebp-0x8], 0xb */
            ii(0x1015_a665, 2); if(jnzd(0x1015_a669, 0x2)) goto l_0x1015_a669; /* jnz 0x1015a669 */
        l_0x1015_a667:
            ii(0x1015_a667, 2); jmpd(0x1015_a670, 0x7); goto l_0x1015_a670; /* jmp 0x1015a670 */
        l_0x1015_a669:
            ii(0x1015_a669, 5); cmp(memw_a32[ss, ebp - 0x8], 0xa);      /* cmp word [ebp-0x8], 0xa */
            ii(0x1015_a66e, 2); if(jnzd(0x1015_a672, 0x2)) goto l_0x1015_a672; /* jnz 0x1015a672 */
        l_0x1015_a670:
            ii(0x1015_a670, 2); jmpd(0x1015_a679, 0x7); goto l_0x1015_a679; /* jmp 0x1015a679 */
        l_0x1015_a672:
            ii(0x1015_a672, 5); cmp(memw_a32[ss, ebp - 0x8], 0x3);      /* cmp word [ebp-0x8], 0x3 */
            ii(0x1015_a677, 2); if(jnzd(0x1015_a68c, 0x13)) goto l_0x1015_a68c; /* jnz 0x1015a68c */
        l_0x1015_a679:
            ii(0x1015_a679, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1015_a67c, 4); mov(ax, memw_a32[ds, eax + 0x33]);      /* mov ax, [eax+0x33] */
            ii(0x1015_a680, 1); inc(eax);                               /* inc eax */
            ii(0x1015_a681, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1015_a684, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1015_a687, 5); calld(0x1014_9b07, -0x10b85);           /* call 0x10149b07 */
        l_0x1015_a68c:
            ii(0x1015_a68c, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1015_a68f, 5); calld(0x100a_8d5f, -0xb1935);           /* call 0x100a8d5f */
        l_0x1015_a694:
            ii(0x1015_a694, 3); mov(edx, memd_a32[ss, ebp - 0x28]);     /* mov edx, [ebp-0x28] */
            ii(0x1015_a697, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_a69a, 5); calld(0x1007_66ac, -0xe3ff3);           /* call 0x100766ac */
            ii(0x1015_a69f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_a6a2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_a6a4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_a6a5, 1); popd(edi);                              /* pop edi */
            ii(0x1015_a6a6, 1); popd(esi);                              /* pop esi */
            ii(0x1015_a6a7, 3); retd(0x14); return;                     /* ret 0x14 */
        }
    }
}
