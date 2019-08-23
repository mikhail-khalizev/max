using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_890d-5e83ab1b")]
        public void Method_1011_890d()
        {
            ii(0x1011_890d, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1011_8912, 5); calld(Definitions.sys_check_available_stack_size, 0x4_d43b); /* call 0x10165d52 */
            ii(0x1011_8917, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_8918, 1); pushd(esi);                             /* push esi */
            ii(0x1011_8919, 1); pushd(edi);                             /* push edi */
            ii(0x1011_891a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_891b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_891d, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1011_8923, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_8926, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1011_8929, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1011_892c, 7); cmp(memb_a32[ds, 0x101c_3915], 0);      /* cmp byte [0x101c3915], 0x0 */
            ii(0x1011_8933, 2); if(jzd(0x1011_8942, 0xd)) goto l_0x1011_8942; /* jz 0x10118942 */
            ii(0x1011_8935, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
            ii(0x1011_893c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_893f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x1011_8942:
            ii(0x1011_8942, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
            ii(0x1011_8949, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1011_894c, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1011_894f, 3); sub(memb_a32[ds, edx + 0x4e], al);      /* sub [edx+0x4e], al */
            ii(0x1011_8952, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1011_8955, 4); cmp(memb_a32[ds, edx + 0x4f], 0);       /* cmp byte [edx+0x4f], 0x0 */
            ii(0x1011_8959, 2); if(jzd(0x1011_8982, 0x27)) goto l_0x1011_8982; /* jz 0x10118982 */
            ii(0x1011_895b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_895e, 3); mov(al, memb_a32[ds, eax + 0x4f]);      /* mov al, [eax+0x4f] */
            ii(0x1011_8961, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1011_8963, 3); sub(eax, memd_a32[ss, ebp - 0x8]);      /* sub eax, [ebp-0x8] */
            ii(0x1011_8966, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_8969, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1011_896d, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1011_8970, 2); if(jged(0x1011_8979, 0x7)) goto l_0x1011_8979; /* jge 0x10118979 */
            ii(0x1011_8972, 7); mov(memd_a32[ss, ebp - 0x10], 0x1);     /* mov dword [ebp-0x10], 0x1 */
        l_0x1011_8979:
            ii(0x1011_8979, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1011_897c, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1011_897f, 3); mov(memb_a32[ds, edx + 0x4f], al);      /* mov [edx+0x4f], al */
        l_0x1011_8982:
            ii(0x1011_8982, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_8985, 5); calld(0x1007_623c, -0xa_274e);          /* call 0x1007623c */
            ii(0x1011_898a, 4); cmp(memb_a32[ds, eax + 0x16], 0);       /* cmp byte [eax+0x16], 0x0 */
            ii(0x1011_898e, 2); if(jnzd(0x1011_89ea, 0x5a)) goto l_0x1011_89ea; /* jnz 0x101189ea */
            ii(0x1011_8990, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_8993, 5); calld(0x1007_623c, -0xa_275c);          /* call 0x1007623c */
            ii(0x1011_8998, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1011_899b, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1011_899e, 3); mov(eax, memd_a32[ds, eax + 0xe]);      /* mov eax, [eax+0xe] */
            ii(0x1011_89a1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_89a4, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1011_89a7, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1011_89aa, 4); mov(ax, memw_a32[ds, eax + 0x14]);      /* mov ax, [eax+0x14] */
            ii(0x1011_89ae, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1011_89b1, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_89b4, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x1011_89b7, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_89bc, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1011_89c0, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1011_89c3, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_89c5, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1011_89c8, 3); idiv(memd_a32[ss, ebp - 0x18]);         /* idiv dword [ebp-0x18] */
            ii(0x1011_89cb, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1011_89ce, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_89d1, 3); mov(al, memb_a32[ds, eax + 0x50]);      /* mov al, [eax+0x50] */
            ii(0x1011_89d4, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_89d9, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x1011_89dd, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1011_89df, 2); if(jged(0x1011_89ea, 0x9)) goto l_0x1011_89ea; /* jge 0x101189ea */
            ii(0x1011_89e1, 3); mov(al, memb_a32[ss, ebp - 0x20]);      /* mov al, [ebp-0x20] */
            ii(0x1011_89e4, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1011_89e7, 3); mov(memb_a32[ds, edx + 0x50], al);      /* mov [edx+0x50], al */
        l_0x1011_89ea:
            ii(0x1011_89ea, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_89ec, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_89ed, 1); popd(edi);                              /* pop edi */
            ii(0x1011_89ee, 1); popd(esi);                              /* pop esi */
            ii(0x1011_89ef, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_89f0, 1); retd();                                 /* ret */
        }
    }
}
