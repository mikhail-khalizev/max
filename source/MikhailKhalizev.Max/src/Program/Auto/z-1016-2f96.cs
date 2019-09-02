using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_2f96-27981026")]
        public void Method_1016_2f96()
        {
            ii(0x1016_2f96, 5); push(0x24);                             /* push 0x24 */
            ii(0x1016_2f9b, 5); call(Definitions.sys_check_available_stack_size, 0x2db2); /* call 0x10165d52 */
            ii(0x1016_2fa0, 1); push(ecx);                              /* push ecx */
            ii(0x1016_2fa1, 1); push(esi);                              /* push esi */
            ii(0x1016_2fa2, 1); push(edi);                              /* push edi */
            ii(0x1016_2fa3, 1); push(ebp);                              /* push ebp */
            ii(0x1016_2fa4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_2fa6, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1016_2fac, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1016_2faf, 3); mov(memb[ss, ebp - 8], dl);             /* mov [ebp-0x8], dl */
            ii(0x1016_2fb2, 3); mov(memb[ss, ebp - 4], bl);             /* mov [ebp-0x4], bl */
            ii(0x1016_2fb5, 4); mov(memb[ss, ebp - 0x10], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x1016_2fb9, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1016_2fbc, 4); cmp(memb[ds, eax + 0x3d], 9);           /* cmp byte [eax+0x3d], 0x9 */
            ii(0x1016_2fc0, 2); if(jz(0x1016_2fcb, 9)) goto l_0x1016_2fcb; /* jz 0x10162fcb */
            ii(0x1016_2fc2, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1016_2fc5, 4); cmp(memb[ds, eax + 0x3e], 0xe);         /* cmp byte [eax+0x3e], 0xe */
            ii(0x1016_2fc9, 2); if(jnz(0x1016_2fd0, 5)) goto l_0x1016_2fd0; /* jnz 0x10162fd0 */
        l_0x1016_2fcb:
            ii(0x1016_2fcb, 5); jmp(0x1016_304c, 0x7c); goto l_0x1016_304c; /* jmp 0x1016304c */
        l_0x1016_2fd0:
            ii(0x1016_2fd0, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1016_2fd3, 4); cmp(memb[ds, eax + 0x3d], 0x16);        /* cmp byte [eax+0x3d], 0x16 */
            ii(0x1016_2fd7, 2); if(jnz(0x1016_2fe1, 8)) goto l_0x1016_2fe1; /* jnz 0x10162fe1 */
            ii(0x1016_2fd9, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1016_2fdc, 5); call(0x1016_186c, -0x1775);             /* call 0x1016186c */
        l_0x1016_2fe1:
            ii(0x1016_2fe1, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1016_2fe4, 4); cmp(memb[ds, eax + 0x3e], 0x2a);        /* cmp byte [eax+0x3e], 0x2a */
            ii(0x1016_2fe8, 2); if(jnz(0x1016_2ffc, 0x12)) goto l_0x1016_2ffc; /* jnz 0x10162ffc */
            ii(0x1016_2fea, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1016_2fed, 4); mov(memb[ds, eax + 0x3d], 0);           /* mov byte [eax+0x3d], 0x0 */
            ii(0x1016_2ff1, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1016_2ff4, 4); mov(memb[ds, eax + 0x3e], 1);           /* mov byte [eax+0x3e], 0x1 */
            ii(0x1016_2ff8, 4); mov(memb[ss, ebp - 0x10], 1);           /* mov byte [ebp-0x10], 0x1 */
        l_0x1016_2ffc:
            ii(0x1016_2ffc, 4); cmp(memb[ss, ebp - 8], 9);              /* cmp byte [ebp-0x8], 0x9 */
            ii(0x1016_3000, 2); if(jz(0x1016_300b, 9)) goto l_0x1016_300b; /* jz 0x1016300b */
            ii(0x1016_3002, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1016_3005, 4); cmp(memb[ds, eax + 0x3d], 3);           /* cmp byte [eax+0x3d], 0x3 */
            ii(0x1016_3009, 2); if(jz(0x1016_303e, 0x33)) goto l_0x1016_303e; /* jz 0x1016303e */
        l_0x1016_300b:
            ii(0x1016_300b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1016_300e, 4); cmp(memb[ds, eax + 0x3d], 6);           /* cmp byte [eax+0x3d], 0x6 */
            ii(0x1016_3012, 2); if(jz(0x1016_302c, 0x18)) goto l_0x1016_302c; /* jz 0x1016302c */
            ii(0x1016_3014, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1016_3017, 3); mov(dl, memb[ds, eax + 0x3d]);          /* mov dl, [eax+0x3d] */
            ii(0x1016_301a, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1016_301d, 3); mov(memb[ds, eax + 0x3f], dl);          /* mov [eax+0x3f], dl */
            ii(0x1016_3020, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1016_3023, 3); mov(dl, memb[ds, eax + 0x3e]);          /* mov dl, [eax+0x3e] */
            ii(0x1016_3026, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1016_3029, 3); mov(memb[ds, eax + 0x40], dl);          /* mov [eax+0x40], dl */
        l_0x1016_302c:
            ii(0x1016_302c, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1016_302f, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1016_3032, 3); mov(memb[ds, edx + 0x3d], al);          /* mov [edx+0x3d], al */
            ii(0x1016_3035, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x1016_3038, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1016_303b, 3); mov(memb[ds, edx + 0x3e], al);          /* mov [edx+0x3e], al */
        l_0x1016_303e:
            ii(0x1016_303e, 4); cmp(memb[ss, ebp - 0x10], 0);           /* cmp byte [ebp-0x10], 0x0 */
            ii(0x1016_3042, 2); if(jz(0x1016_304c, 8)) goto l_0x1016_304c; /* jz 0x1016304c */
            ii(0x1016_3044, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1016_3047, 5); call(0x1011_fe27, -0x4_3225);           /* call 0x1011fe27 */
        l_0x1016_304c:
            ii(0x1016_304c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_304e, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_304f, 1); pop(edi);                               /* pop edi */
            ii(0x1016_3050, 1); pop(esi);                               /* pop esi */
            ii(0x1016_3051, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_3052, 1); ret();                                  /* ret */
        }
    }
}
