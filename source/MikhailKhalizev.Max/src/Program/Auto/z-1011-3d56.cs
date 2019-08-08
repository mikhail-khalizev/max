using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("153984dd-1d80-4ee3-a980-7fed3b5fe7eb")]
        public void Method_1011_3d56()
        {
            ii(0x1011_3d56, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1011_3d5b, 5); calld(Definitions.sys_check_available_stack_size, 0x5_1ff2); /* call 0x10165d52 */
            ii(0x1011_3d60, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_3d61, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_3d62, 1); pushd(esi);                             /* push esi */
            ii(0x1011_3d63, 1); pushd(edi);                             /* push edi */
            ii(0x1011_3d64, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_3d65, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_3d67, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1011_3d6d, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_3d70, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_3d73, 5); calld(0x1012_ac94, 0x1_6f1c);           /* call 0x1012ac94 */
            ii(0x1011_3d78, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_3d7b, 3); mov(al, memb_a32[ds, eax + 0x11]);      /* mov al, [eax+0x11] */
            ii(0x1011_3d7e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_3d83, 5); cmp(eax, 0xff);                         /* cmp eax, 0xff */
            ii(0x1011_3d88, 2); if(jzd(0x1011_3daa, 0x20)) goto l_0x1011_3daa; /* jz 0x10113daa */
            ii(0x1011_3d8a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_3d8d, 3); mov(al, memb_a32[ds, eax + 0x11]);      /* mov al, [eax+0x11] */
            ii(0x1011_3d90, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1011_3d92, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_3d95, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_3d98, 5); calld(0x1011_3129, -0xc74);             /* call 0x10113129 */
            ii(0x1011_3d9d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_3da0, 4); mov(memb_a32[ds, eax + 0x11], 0xff);    /* mov byte [eax+0x11], 0xff */
            ii(0x1011_3da4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_3da7, 3); dec(memb_a32[ds, eax + 0xf]);           /* dec byte [eax+0xf] */
        l_0x1011_3daa:
            ii(0x1011_3daa, 4); mov(memb_a32[ss, ebp - 0xc], 0x4);      /* mov byte [ebp-0xc], 0x4 */
            ii(0x1011_3dae, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1011_3db2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_3db4, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1011_3db7, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1011_3db9, 2); if(jld(0x1011_3dc4, 0x9)) goto l_0x1011_3dc4; /* jl 0x10113dc4 */
            ii(0x1011_3dbb, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_3dbd, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1011_3dc0, 1); dec(eax);                               /* dec eax */
            ii(0x1011_3dc1, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
        l_0x1011_3dc4:
            ii(0x1011_3dc4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_3dc7, 3); mov(al, memb_a32[ds, eax + 0x8]);       /* mov al, [eax+0x8] */
            ii(0x1011_3dca, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_3dcf, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_3dd1, 2); if(jnzd(0x1011_3e36, 0x63)) goto l_0x1011_3e36; /* jnz 0x10113e36 */
            ii(0x1011_3dd3, 4); mov(memb_a32[ss, ebp - 0x18], 0x1);     /* mov byte [ebp-0x18], 0x1 */
        l_0x1011_3dd7:
            ii(0x1011_3dd7, 4); cmp(memb_a32[ss, ebp - 0x18], 0);       /* cmp byte [ebp-0x18], 0x0 */
            ii(0x1011_3ddb, 2); if(jzd(0x1011_3e2c, 0x4f)) goto l_0x1011_3e2c; /* jz 0x10113e2c */
            ii(0x1011_3ddd, 5); calld(0x1012_ac94, 0x1_6eb2);           /* call 0x1012ac94 */
            ii(0x1011_3de2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_3de5, 3); mov(eax, memd_a32[ds, eax + 0xa]);      /* mov eax, [eax+0xa] */
            ii(0x1011_3de8, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_3deb, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_3ded, 2); if(jzd(0x1011_3e2c, 0x3d)) goto l_0x1011_3e2c; /* jz 0x10113e2c */
            ii(0x1011_3def, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1011_3df6, 2); jmpd(0x1011_3dfe, 0x6); goto l_0x1011_3dfe; /* jmp 0x10113dfe */
        l_0x1011_3df8:
            ii(0x1011_3df8, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1011_3dfb, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
        l_0x1011_3dfe:
            ii(0x1011_3dfe, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1011_3e02, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_3e04, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1011_3e07, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1011_3e09, 2); if(jzd(0x1011_3e2a, 0x1f)) goto l_0x1011_3e2a; /* jz 0x10113e2a */
            ii(0x1011_3e0b, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1011_3e0f, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_3e11, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_3e14, 7); mov(dx, memw_a32[ds, eax + 0x4dc]);     /* mov dx, [eax+0x4dc] */
            ii(0x1011_3e1b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_3e1e, 4); cmp(dx, memw_a32[ds, eax + 0xc]);       /* cmp dx, [eax+0xc] */
            ii(0x1011_3e22, 2); if(jnzd(0x1011_3e28, 0x4)) goto l_0x1011_3e28; /* jnz 0x10113e28 */
            ii(0x1011_3e24, 4); mov(memb_a32[ss, ebp - 0x18], 0);       /* mov byte [ebp-0x18], 0x0 */
        l_0x1011_3e28:
            ii(0x1011_3e28, 2); jmpd(0x1011_3df8, -0x32); goto l_0x1011_3df8; /* jmp 0x10113df8 */
        l_0x1011_3e2a:
            ii(0x1011_3e2a, 2); jmpd(0x1011_3dd7, -0x55); goto l_0x1011_3dd7; /* jmp 0x10113dd7 */
        l_0x1011_3e2c:
            ii(0x1011_3e2c, 4); cmp(memb_a32[ss, ebp - 0x18], 0);       /* cmp byte [ebp-0x18], 0x0 */
            ii(0x1011_3e30, 6); if(jnzd(0x1011_3f89, 0x153)) goto l_0x1011_3f89; /* jnz 0x10113f89 */
        l_0x1011_3e36:
            ii(0x1011_3e36, 4); mov(memb_a32[ss, ebp - 0x10], 0x4);     /* mov byte [ebp-0x10], 0x4 */
            ii(0x1011_3e3a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_3e3d, 7); cmp(memb_a32[ds, eax + 0x51f], 0);      /* cmp byte [eax+0x51f], 0x0 */
            ii(0x1011_3e44, 2); if(jzd(0x1011_3ea5, 0x5f)) goto l_0x1011_3ea5; /* jz 0x10113ea5 */
            ii(0x1011_3e46, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1011_3e4d, 2); jmpd(0x1011_3e55, 0x6); goto l_0x1011_3e55; /* jmp 0x10113e55 */
        l_0x1011_3e4f:
            ii(0x1011_3e4f, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1011_3e52, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
        l_0x1011_3e55:
            ii(0x1011_3e55, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1011_3e59, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_3e5b, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1011_3e5e, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1011_3e60, 2); if(jzd(0x1011_3ea5, 0x43)) goto l_0x1011_3ea5; /* jz 0x10113ea5 */
            ii(0x1011_3e62, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1011_3e66, 3); imul(eax, eax, 0x1e);                   /* imul eax, eax, 0x1e */
            ii(0x1011_3e69, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_3e6c, 6); add(edx, 0x520);                        /* add edx, 0x520 */
            ii(0x1011_3e72, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_3e74, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_3e77, 5); add(eax, 0x21a);                        /* add eax, 0x21a */
            ii(0x1011_3e7c, 5); calld(Definitions.sys_strcasecmp, 0x5_22af); /* call 0x10166130 */
            ii(0x1011_3e81, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_3e83, 2); if(jnzd(0x1011_3ea3, 0x1e)) goto l_0x1011_3ea3; /* jnz 0x10113ea3 */
            ii(0x1011_3e85, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1011_3e89, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_3e8b, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_3e8e, 6); mov(eax, memd_a32[ds, eax + 0x4da]);    /* mov eax, [eax+0x4da] */
            ii(0x1011_3e94, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_3e97, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_3e99, 2); if(jnzd(0x1011_3ea3, 0x8)) goto l_0x1011_3ea3; /* jnz 0x10113ea3 */
            ii(0x1011_3e9b, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x1011_3e9e, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x1011_3ea1, 2); jmpd(0x1011_3ea5, 0x2); goto l_0x1011_3ea5; /* jmp 0x10113ea5 */
        l_0x1011_3ea3:
            ii(0x1011_3ea3, 2); jmpd(0x1011_3e4f, -0x56); goto l_0x1011_3e4f; /* jmp 0x10113e4f */
        l_0x1011_3ea5:
            ii(0x1011_3ea5, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_3ea7, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1011_3eaa, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1011_3ead, 2); if(jnzd(0x1011_3ef6, 0x47)) goto l_0x1011_3ef6; /* jnz 0x10113ef6 */
            ii(0x1011_3eaf, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1011_3eb3, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_3eb5, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_3eb8, 6); mov(eax, memd_a32[ds, eax + 0x4da]);    /* mov eax, [eax+0x4da] */
            ii(0x1011_3ebe, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_3ec1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_3ec3, 2); if(jnzd(0x1011_3ef6, 0x31)) goto l_0x1011_3ef6; /* jnz 0x10113ef6 */
            ii(0x1011_3ec5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_3ec8, 6); mov(al, memb_a32[ds, eax + 0x51f]);     /* mov al, [eax+0x51f] */
            ii(0x1011_3ece, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_3ed3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_3ed5, 2); if(jzd(0x1011_3ef0, 0x19)) goto l_0x1011_3ef0; /* jz 0x10113ef0 */
            ii(0x1011_3ed7, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1011_3edb, 3); imul(eax, eax, 0x1e);                   /* imul eax, eax, 0x1e */
            ii(0x1011_3ede, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_3ee1, 6); mov(al, memb_a32[ds, eax + 0x520]);     /* mov al, [eax+0x520] */
            ii(0x1011_3ee7, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_3eec, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_3eee, 2); if(jzd(0x1011_3ef6, 0x6)) goto l_0x1011_3ef6; /* jz 0x10113ef6 */
        l_0x1011_3ef0:
            ii(0x1011_3ef0, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1011_3ef3, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
        l_0x1011_3ef6:
            ii(0x1011_3ef6, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_3ef8, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1011_3efb, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1011_3efe, 6); if(jnzd(0x1011_3f69, 0x65)) goto l_0x1011_3f69; /* jnz 0x10113f69 */
            ii(0x1011_3f04, 6); mov(memw_a32[ss, ebp - 0x14], 0);       /* mov word [ebp-0x14], 0x0 */
            ii(0x1011_3f0a, 2); jmpd(0x1011_3f13, 0x7); goto l_0x1011_3f13; /* jmp 0x10113f13 */
        l_0x1011_3f0c:
            ii(0x1011_3f0c, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1011_3f0f, 4); inc(memw_a32[ss, ebp - 0x14]);          /* inc word [ebp-0x14] */
        l_0x1011_3f13:
            ii(0x1011_3f13, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1011_3f17, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_3f19, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1011_3f1c, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1011_3f1e, 2); if(jzd(0x1011_3f69, 0x49)) goto l_0x1011_3f69; /* jz 0x10113f69 */
            ii(0x1011_3f20, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1011_3f24, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_3f26, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_3f29, 6); mov(eax, memd_a32[ds, eax + 0x4da]);    /* mov eax, [eax+0x4da] */
            ii(0x1011_3f2f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_3f32, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_3f34, 2); if(jnzd(0x1011_3f67, 0x31)) goto l_0x1011_3f67; /* jnz 0x10113f67 */
            ii(0x1011_3f36, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_3f39, 7); cmp(memb_a32[ds, eax + 0x51f], 0);      /* cmp byte [eax+0x51f], 0x0 */
            ii(0x1011_3f40, 2); if(jzd(0x1011_3f5b, 0x19)) goto l_0x1011_3f5b; /* jz 0x10113f5b */
            ii(0x1011_3f42, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1011_3f46, 3); imul(eax, eax, 0x1e);                   /* imul eax, eax, 0x1e */
            ii(0x1011_3f49, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1011_3f4c, 6); mov(al, memb_a32[ds, eax + 0x520]);     /* mov al, [eax+0x520] */
            ii(0x1011_3f52, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_3f57, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_3f59, 2); if(jzd(0x1011_3f5d, 0x2)) goto l_0x1011_3f5d; /* jz 0x10113f5d */
        l_0x1011_3f5b:
            ii(0x1011_3f5b, 2); jmpd(0x1011_3f5f, 0x2); goto l_0x1011_3f5f; /* jmp 0x10113f5f */
        l_0x1011_3f5d:
            ii(0x1011_3f5d, 2); jmpd(0x1011_3f67, 0x8); goto l_0x1011_3f67; /* jmp 0x10113f67 */
        l_0x1011_3f5f:
            ii(0x1011_3f5f, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x1011_3f62, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x1011_3f65, 2); jmpd(0x1011_3f69, 0x2); goto l_0x1011_3f69; /* jmp 0x10113f69 */
        l_0x1011_3f67:
            ii(0x1011_3f67, 2); jmpd(0x1011_3f0c, -0x5d); goto l_0x1011_3f0c; /* jmp 0x10113f0c */
        l_0x1011_3f69:
            ii(0x1011_3f69, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_3f6b, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1011_3f6e, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1011_3f71, 2); if(jzd(0x1011_3f89, 0x16)) goto l_0x1011_3f89; /* jz 0x10113f89 */
            ii(0x1011_3f73, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_3f75, 3); mov(dl, memb_a32[ss, ebp - 0x10]);      /* mov dl, [ebp-0x10] */
            ii(0x1011_3f78, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_3f7b, 3); add(edx, 0xd);                          /* add edx, 0xd */
            ii(0x1011_3f7e, 3); mov(memd_a32[ds, eax + 0x4], edx);      /* mov [eax+0x4], edx */
            ii(0x1011_3f81, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_3f84, 5); calld(0x1011_3fec, 0x63);               /* call 0x10113fec */
        l_0x1011_3f89:
            ii(0x1011_3f89, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_3f8b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_3f8c, 1); popd(edi);                              /* pop edi */
            ii(0x1011_3f8d, 1); popd(esi);                              /* pop esi */
            ii(0x1011_3f8e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_3f8f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_3f90, 1); retd(); return;                         /* ret */
        }
    }
}
